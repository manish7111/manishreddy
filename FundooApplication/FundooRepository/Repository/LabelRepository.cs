using FundooModel;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FundooRepository.Repository
{

    public class LabelRepository:ILabelRepository
    {
        private readonly UserContext context = null;
        public LabelRepository()
        {

        }
        public LabelRepository(UserContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// Adds the labels.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string AddLabels(LabelModel model)
        {
            var addLabel = new LabelModel()
            {
                Id=model.Id,
                Email = model.Email,
                Label = model.Label
            };
            try
            {
                this.context.Labels.Add(addLabel);
                var result = this.context.SaveChanges();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets the labels.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<LabelModel> GetLabels(string email)
        {
            try
            {
                var list = new List<LabelModel>();
                var labels = from t in this.context.Labels where t.Email == email select t;
                foreach (var items in labels)
                {
                    list.Add(items);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Updates the labels.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string UpdateLabels(LabelModel model)
        {
            LabelModel label = this.context.Labels.Where(t => t.Id == model.Id).FirstOrDefault();
            label.Label = model.Label;
            try
            {
                var result = this.context.SaveChanges();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string DeleteLabel(int id)
        {
            LabelModel label = this.context.Labels.Where(t => t.Id == id).FirstOrDefault();
            try
            {
                this.context.Labels.Remove(label);
                var result = this.context.SaveChanges();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
