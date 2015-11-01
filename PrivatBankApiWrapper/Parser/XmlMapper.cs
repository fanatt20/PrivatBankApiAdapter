using System;
using System.IO;
using System.Xml.Serialization;
using PrivatBankApiWrapper.DomainObjects;
using PrivatBankApiWrapper.ResponseDto.Balance;
using PrivatBankApiWrapper.TypeSafe_Enums;

namespace PrivatBankApiWrapper.Parser
{
    internal class XmlMapper
    {
        public static Balance MapBalance(string data)
        {
            BalanceDto balanceDto;
            var serializer = new XmlSerializer(typeof (BalanceDto));
            using (TextReader reader = new StringReader(data))
            {
                balanceDto = (BalanceDto) serializer.Deserialize(reader);
            }

            var currency = MapCurrency(balanceDto);
            var status = MapStatus(balanceDto);
            var card = MapCard(balanceDto, currency, status);
            var result = MapBalance(balanceDto, card);

            return result;
        }

        private static Currency MapCurrency(BalanceDto balanceDto)
        {
            return new Currency(balanceDto.BalanceDataDto.info[0].Card.Currency);
        }

        private static Status MapStatus(BalanceDto balanceDto)
        {
            return new Status(balanceDto.BalanceDataDto.info[0].Card.CardStat);
        }

        private static Card MapCard(BalanceDto balanceDto, Currency currency, Status status)
        {
            return new Card
            {
                Account = balanceDto.BalanceDataDto.info[0].Card.Account,
                CardName = balanceDto.BalanceDataDto.info[0].Card.AccName,
                CardNumber = balanceDto.BalanceDataDto.info[0].Card.CardNumber,
                CardType = balanceDto.BalanceDataDto.info[0].Card.CardType,
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