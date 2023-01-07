﻿using AdvancedWebTechnologiesHRM.App.Components;
using AdvancedWebTechnologiesHRM.App.Services;
using AdvancedWebTechnologiesHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedWebTechnologiesHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }
    }
}
