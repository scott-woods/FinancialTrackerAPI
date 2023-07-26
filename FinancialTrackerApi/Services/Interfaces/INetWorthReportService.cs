﻿using FinancialTrackerApi.Models.DTOs;

namespace FinancialTrackerApi.Services.Interfaces
{
    public interface INetWorthReportService
    {
        public List<NetWorthReportDTO> GetNetWorthReports(int userId);
        public bool AddNetWorthReport(int userId, NetWorthReportDTO netWorthReportDTO);
    }
}
