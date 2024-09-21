using System;
using System.IO;
using System.Windows.Forms;

namespace Censtar
{
    public class OrderManager
    {
        private decimal? _liters;
        private decimal? _amount;
        private decimal _priceDelimiter;

        public OrderManager(string configPath)
        {
            LoadPriceDelimiter(configPath);
        }

        // Загрузка коэффициента цены из config.ini
        private void LoadPriceDelimiter(string configPath)
        {
            if (File.Exists(configPath))
            {
                string priceDelimiterString = IniFileHelper.ReadIni("PriceSettings", "PriceDelimiter", configPath);

                if (decimal.TryParse(priceDelimiterString, out decimal parsedPriceDelimiter))
                {
                    _priceDelimiter = parsedPriceDelimiter ; // Для преобразования 5566 в 55,66
                }
                else
                {
                    MessageBox.Show("Некорректное значение PriceDelimiter в config.ini", "Ошибка");
                    _priceDelimiter = 0; // Устанавливаем значение по умолчанию, если парсинг не удался
                }
            }
            else
            {
                MessageBox.Show("Файл config.ini не найден", "Ошибка");
                _priceDelimiter = 0; // Устанавливаем значение по умолчанию
            }
        }

        public void SetLiters(decimal liters)
        {
            _liters = liters;
            _amount = null; // Очищаем поле для суммы
        }

        public void SetAmount(decimal amount)
        {
            _amount = amount;
            _liters = null; // Очищаем поле для литров
        }

        // Получение текущей цены
        public decimal GetCurrentPrice()
        {
            return _priceDelimiter;
        }
        public bool ValidateOrder()
        {
            return _liters.HasValue || _amount.HasValue;
        }

        public string GetOrderSummary()
        {
            if (_liters.HasValue)
            {
                decimal totalAmount = _liters.Value * _priceDelimiter;
                return $"Заказано {_liters} литров на сумму {totalAmount} руб.";
            }
            if (_amount.HasValue)
            {
                decimal totalLiters = _amount.Value / _priceDelimiter;
                return $"Заказано на сумму {_amount} руб. Объем {totalLiters:F2} литров.";
            }
            return "Данные заказа не указаны.";
        }
    }
}
