using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PrivatBankApiWrapper.DomainObjects;
using PrivatBankApiWrapper.ResponseDto.Balance;
using PrivatBankApiWrapper.ResponseDto.RestIndividual;
using PrivatBankApiWrapper.TypeSafe_Enums;

namespace PrivatBankApiWrapper.Parser
{
    internal class XmlMapper
    {
        public static Balance MapBalance(string data)
        {
            var balanceDto = Deserialize<BalanceDto>(data);

            var currency = MapCurrency(balanceDto);
            var status = MapStatus(balanceDto);
            var card = MapCard(balanceDto.BalanceDataDto.info[0], currency, status);
            var result = MapBalance(balanceDto, card);

            return result;
        }

        public static RestIndividual MapRestIndividual(string data)
        {
            var restIndividualDto = Deserialize<RestIndividualResponse>(data);

            var transactions = MapTransactions(restIndividualDto.Data.info[0].Statements);
            var rest = MapRestIndividual(restIndividualDto.Data.info[0], transactions);

            return rest;
        }

        private static TResult Deserialize<TResult>(string data)
        {
            TResult restIndividualDto;
            var serializer = new XmlSerializer(typeof (TResult));
            using (var reader = new StringReader(data))
            {
                restIndividualDto = (TResult) serializer.Deserialize(reader);
            }
            return restIndividualDto;
        }

        private static RestIndividual MapRestIndividual(StatementsDto restIndividualDto, Transaction[] transactions)
        {
            return new RestIndividual {Credit = restIndividualDto.Credit, Debet = restIndividualDto.Debet};
        }

        private static Transaction[] MapTransactions(TransactionDto[] transactionDto)
        {
            return transactionDto.Select(transaction => new Transaction
            {
                Amount = new Money
                {
                    Currency = new Currency(transaction.Amount.Split(' ')[1]),
                    Value = decimal.Parse(transaction.Amount.Split(' ')[0])
                },
                CardAmount = new Money
                {
                    Currency = new Currency(transaction.CardAmount.Split(' ')[1]),
                    Value = decimal.Parse(transaction.CardAmount.Split(' ')[0])
                },
                CardRest = new Money
                {
                    Currency = new Currency(transaction.Rest.Split(' ')[1]),
                    Value = decimal.Parse(transaction.Rest.Split(' ')[0])
                },
                Card = transaction.Card,
                Terminal = transaction.Terminal,
                Date = DateTime.Parse(transaction.TransactionDate),
                Details = transaction.Description
            }).ToArray();
        }

        private static Currency MapCurrency(BalanceDto balanceDto)
        {
            return new Currency(balanceDto.BalanceDataDto.info[0].Card.Currency);
        }

        private static Status MapStatus(BalanceDto balanceDto)
        {
            return new Status(balanceDto.BalanceDataDto.info[0].Card.CardStat);
        }

        private static Card MapCard(CardBalanceDto balanceDto, Currency currency, Status status)
        {
            return new Card
            {
                Account = balanceDto.Card.Account,
                CardName = balanceDto.Card.AccName,
                CardNumber = balanceDto.Card.CardNumber,
                CardType = balanceDto.Card.CardType,
                Currency = currency,
                Status = status
            };
        }

        private static Balance MapBalance(BalanceDto balanceDto, Card card)
        {
            return new Balance
            {
                AvaibleBalance = balanceDto.BalanceDataDto.info[0].AvBalance,
                BalanceTime = DateTime.Parse(balanceDto.BalanceDataDto.info[0].BalDate),
                CreditLimit = balanceDto.BalanceDataDto.info[0].FinLimit,
                Value = balanceDto.BalanceDataDto.info[0].Balance,
                Card = card
            };
        }
    }
}