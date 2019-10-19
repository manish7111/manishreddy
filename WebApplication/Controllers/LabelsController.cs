// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelsController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// LabelsController is a controller class.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class LabelsController : ApiController
    {
        /// <summary>
        /// The label
        /// </summary>
        private ILabel label;
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsController"/> class.
        /// </summary>
        public LabelsController()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsController"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        public LabelsController(ILabel label)
        {
            this.label = label;
        }
        /// <summary>
        /// Adds the labels.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("label")]
        public IHttpActionResult AddLabels(LabelModel model)
        {
            var result = this.label.AddLabels(model);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("getlabel")]
        public IHttpActionResult GetLabel(string email)
        {
            IList<LabelModel> result = this.label.GetLabels(email);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="Label">The label.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("updatelabel")]
        public IHttpActionResult UpdateLabel(int Id,string Label)
        {
            var result = this.label.UpdateLabels(Id,Label);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deletelabel")]
        public IHttpActionResult DeleteLabel(int id)
        {
            var result = this.label.DeleteLabel(id);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Gets the label by label.
        /// </summary>
        /// <param name="Label">The label.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("getlabels")]
        public IHttpActionResult GetLabelByLabel(string Label)
        {
            IList<NotesModel> result = this.label.GetLabelByLabel(Label);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
    }
}
