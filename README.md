# How to filter items from .NET MAUI ListView?
This example describes how to filter the items from .NET MAUI ListView (SfListView).

**[View KB document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13060/how-to-filter-the-items-in-net-maui-listview-sflistview-using-mvvm)**

## Sample

```xaml
<Grid Margin="0" RowSpacing="0">
    <Grid.RowDefinitions>
        <RowDefinition Height="60" />
        <RowDefinition Height="*" />
    </Grid.RowDefinitions>
    <Grid x:Name="headerGrid" Grid.Row="0" HeightRequest="60" ColumnSpacing="0" RowSpacing="0"  >
        
        <Grid x:Name="seachbar_Grid" BackgroundColor="#FFFFFF">
            <SearchBar x:Name="filterText" BackgroundColor="White" 
            </SearchBar>
        </Grid>
    </Grid>
    <syncfusion:SfListView x:Name="listView" 
                Grid.Row="1"
                SelectionMode="None"
                ItemSpacing="5,2.5,5,2.5"
                ItemsSource="{Binding Items}"
                Background="#f2f1f2"
                ItemSize="100">
        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate x:Name="ItemTemplate">
                <code>
                . . .
                . . .
                <code>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
</Grid>

C#:

SearchBar.TextChanged += SearchBar_TextChanged;

private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
{
    if (ListView.DataSource != null)
    {
        ListView.DataSource.Filter = FilterContacts;
        ListView.DataSource.RefreshFilter();
    }
    ListView.RefreshView();
}

private bool FilterContacts(object obj)
{
    if (SearchBar == null || SearchBar.Text == null)
    return true;
    var taskInfo = obj as TaskInfo;
    return (taskInfo.Title.ToLower().Contains(SearchBar.Text.ToLower())
        || taskInfo.Description.ToLower().Contains(SearchBar.Text.ToLower()));
}
```
