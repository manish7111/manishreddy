using BussinessManager.Interface;
using FundooModel;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessManager.Manager
{
    /// <summary>
    /// LabelManager is a class which implements ILabel interface.
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.ILabel" />
    public class LabelManager : ILabel
    {
        /// <summary>
        /// The label
        /// </summary>
        private readonly ILabelRepository label;
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelManager"/> class.
        /// </summary>
        public LabelManager()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelManager"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        public LabelManager(ILabelRepository label)
        {
            this.label = label;
        }
        /// <summary>
        /// Adds the labels.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string AddLabels(LabelModel model)
        {
            var result = this.label.AddLabels(model);
            return result;
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string DeleteLabel(int id)
        {
            return this.label.DeleteLabel(id);
        }
        /// <summary>
        /// Gets the labels.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public List<LabelModel> GetLabels(string email)
        {
            return this.label.GetLabels(email);
        }
        /// <summary>
        /// Updates the labels.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string UpdateLabels(int id,string Label)
        {
            return this.label.UpdateLabels(id,Label);
        }
        /// <summary>
        /// Gets the label by label.
        /// </summary>
        /// <param name="Label">The label.</param>
        /// <returns></returns>
        public List<NotesModel> GetLabelByLabel(string Label)
        {
            return this.label.GetLabelByLabel(Label);
        }
    }
}
