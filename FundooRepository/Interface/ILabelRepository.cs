using FundooModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Interface
{
    /// <summary>
    /// ILabelRepository is a interface.
    /// </summary>
    public interface ILabelRepository
    {
        /// <summary>
        /// Adds the labels.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        string AddLabels(LabelModel model);
        /// <summary>
        /// Gets the labels.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        List<LabelModel> GetLabels(string email);
        /// <summary>
        /// Updates the labels.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        string UpdateLabels(int id,string Label);
        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string DeleteLabel(int id);
        /// <summary>
        /// Gets the label by label.
        /// </summary>
        /// <param name="Label">The label.</param>
        /// <returns></returns>
        List<NotesModel> GetLabelByLabel(string Label);
    }
}
