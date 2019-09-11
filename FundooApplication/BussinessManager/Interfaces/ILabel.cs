using FundooModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessManager.Interface
{
    public interface ILabel
    {
        string AddLabels(LabelModel model);
        List<LabelModel> GetLabels(string email);
        string UpdateLabels(LabelModel model);
        string DeleteLabel(int id);
    }
}
