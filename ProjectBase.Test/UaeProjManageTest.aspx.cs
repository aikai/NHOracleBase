﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectBase.Utils.Adapter;
using ProjectBase.Utils.JScriptBuilder;
using ProjectBase.Web.PageControl;

namespace ProjectBase.Test
{
    public partial class UaeProjManageTest : ListPage
    {
        protected override void Search()
        {
            try
            {
                var dao = DaoFactory.GetUaeProjectManageDao();

                GridView1.DataSource = dao.GetAll();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridView1.EditIndex = e.NewEditIndex;

                Search();
            }
            catch (Exception ex)
            {
                JavaScriptBuilder.Build(new AlertBuilder(ex.Message));
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridView1.EditIndex = -1;

                Search();
            }
            catch (Exception ex)
            {
                JavaScriptBuilder.Build(new AlertBuilder(ex.Message));
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                var dao = DaoFactory.GetUaeProjectManageDao();

                if (((LinkButton)GridView1.Rows[0].Cells[0].Controls[0]).Text == "Insert")
                {
                    var entity = EntityFactory.CreateUaeProjectManage();

                    entity.ProjCode = ((TextBox)GridView1.Rows[0].Cells[3].Controls[0]).Text;
                    entity.ProjEname = ((TextBox)GridView1.Rows[0].Cells[4].Controls[0]).Text;
                    entity.ProjTname = ((TextBox)GridView1.Rows[0].Cells[5].Controls[0]).Text;

                    dao.Save(entity);
                }
                else
                {
                    var id = GridView1.DataKeys[e.RowIndex].Value;
                    var entity = dao.GetById(id, false);

                    if (entity != null)
                    {
                        entity.ProjCode = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
                        entity.ProjEname = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
                        entity.ProjTname = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;

                        dao.Update(entity);
                    }
                }

                GridView1.EditIndex = -1;
                Search();
            }
            catch (Exception ex)
            {
                JavaScriptBuilder.Build(new AlertBuilder(ex.Message));
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = DaoFactory.GetUaeProjectManageDao();
                var dt = dao.GetAll();

                // Here we'll add a blank row to the returned DataTable
                dt.Insert(0, EntityFactory.CreateUaeProjectManage());

                //Creating the first row of GridView to be Editable
                GridView1.EditIndex = 0;
                GridView1.DataSource = dt;
                GridView1.DataBind();

                //Delete string text id for row insert
                GridView1.Rows[0].Cells[1].Text = "";

                //Changing the Text for Inserting a New Record
                ((LinkButton)GridView1.Rows[0].Cells[0].Controls[0]).Text = "Insert";
            }
            catch (Exception ex)
            {
                JavaScriptBuilder.Build(new AlertBuilder(ex.Message));
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                var dao = DaoFactory.GetUaeProjectManageDao();
                var id = GridView1.DataKeys[e.RowIndex].Value;
                var entity = dao.GetById(id, false);

                if (entity != null)
                {
                    dao.Delete(entity);
                }

                Search();
            }
            catch (Exception ex)
            {
                JavaScriptBuilder.Build(new AlertBuilder(ex.Message));
            }
        }
    }
}