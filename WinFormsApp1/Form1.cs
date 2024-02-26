using BindingListLibrary;
using WinFormsApp1.Classes;
using WinFormsApp1.Models;
using static WinFormsApp1.Classes.Dialogs;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private SortableBindingList<Customer> _customersSortableBindingList;
    private readonly BindingSource _customerBindingSource = [];
    public Form1()
    {
        InitializeComponent();

        Shown += Form_Shown;

    }

    private void Form_Shown(object? sender, EventArgs e)
    {
        Setup();
    }

    private void Setup()
    {
        _customersSortableBindingList = new SortableBindingList<Customer>(
            BogusOperations.CustomersList(3));

        _customerBindingSource.DataSource = _customersSortableBindingList;
        CustomersBindingNavigator.BindingSource = _customerBindingSource;

        CustomersDataGridView.DataSource = _customerBindingSource;

        CustomersDataGridView.ExpandColumns();
        CustomersDataGridView.FixHeaders();

        CustomersBindingNavigator.AboutItemButton.Click += AboutItemButton_Click;
        CustomersBindingNavigator.DeleteItemButton.Click += CustomersDelete_Click;
        CustomersBindingNavigator.AddItemButton.Click += CustomersAdd_Click;
        CustomersBindingNavigator.RemoveDefaultHandlers();

        CustomersDataGridView.UserDeletingRow += CustomersDataGridView_UserDeletingRow;

    }

    private void AboutItemButton_Click(object? sender, EventArgs e)
    {
        Information(this, "", "BindingNavigator sample");
    }

    private void CustomersDelete_Click(object? sender, EventArgs e)
    {

        if (_customerBindingSource.Current is null) return;

        if (AskToRemoveCurrentRow())
        {
            _customerBindingSource.RemoveCurrent();
        }

    }

    private void CustomersDataGridView_UserDeletingRow(object? sender, DataGridViewRowCancelEventArgs e)
    {
        if (_customerBindingSource.Current is null) return;

        if (AskToRemoveCurrentRow())
        {
            e.Cancel = true;
            _customerBindingSource.RemoveCurrent();
        }
        else
        {
            e.Cancel = true;
        }
    }

    private bool AskToRemoveCurrentRow()
    {
        var current = _customersSortableBindingList[_customerBindingSource.Position];
        return Question(this, $"Remove {current.FirstName} {current.LastName}");
    }

    private void CustomersAdd_Click(object? sender, EventArgs e)
    {
        var id = _customerBindingSource.Count == 0 ? 
            0 : 
            _customersSortableBindingList.MaxBy(x => x.Id)!.Id;

        _customersSortableBindingList.Add(BogusOperations.Customer(id+=1));
        _customerBindingSource.MoveLast();
    }
}

