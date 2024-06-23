namespace LabWorkLibrary
{
    /// <summary>
    /// Представляет статические методы для математических вычислений
    /// </summary>
    public static class Maths
    {
        /// <summary>
        /// 2 в 10 степени
        /// </summary>
        public const int BINARY_FACTOR = 1024;

        /// <summary>
        /// Возвращает сумму двух чисел
        /// </summary>
        /// <param name="x">Первое слагаемое</param>
        /// <param name="y">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public static double Sum(double x, double y)
            => x + y;

        /// <summary>
        /// Возвращает разность двух чисел
        /// </summary>
        /// <param name="x">Уменьшаемое</param>
        /// <param name="y">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static double Difference(double x, double y)
            => x - y;

        /// <summary>
        /// Возвращает произведение двух чисел
        /// </summary>
        /// <param name="x">Первый множитель</param>
        /// <param name="y">Второй множитель</param>
        /// <returns>Произведение</returns>
        public static double Multiplication(double x, double y)
            => x * y;

        /// <summary>
        /// Возвращает частное двух чисел
        /// </summary>
        /// <param name="x">Делимое</param>
        /// <param name="y">Делитель</param>
        /// <returns>Частное</returns>
        /// <exception cref="System.DivideByZeroException">Делитель равен 0</exception>
        public static double Quotient(double x, double y)
            => y == 0 ? throw new System.DivideByZeroException("Делитель не может быть равен 0") : x / y;

        /// <summary>
        /// Возвращает площадь прямоугольника
        /// </summary>
        /// <param name="width">Ширина прямоугольника</param>
        /// <param name="height">Высота прямоугольника</param>
        /// <returns>Площадь прямоугольника</returns>
        /// <exception cref="System.ArgumentException">Высота/ширина меньше или равна 0</exception>
        public static double RectangleArea(double width, double height)
            => height <= 0 || width <= 0 ? throw new System.ArgumentException("Недопустимое значение") : width * height;
    }
}
