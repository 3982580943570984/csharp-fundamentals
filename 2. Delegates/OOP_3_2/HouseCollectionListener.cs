namespace Studying;

internal class HouseCollectionListener
{
    public void OnHouseCollectionChanged(object sender, HouseCollectionChangedEventArgs e)
    {
        string message = e.EventType switch
        {
            HouseCollectionChangedEventType.Added => $"Добавлен новый дом: {e.House}",
            HouseCollectionChangedEventType.Removed => $"Удален дом: {e.House}",
            _ => throw new ArgumentException("Недопустимое значение типа события изменения коллекции домов.", nameof(e)),
        };

        MessageBox.Show(message, "Изменение коллекции домов", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
