using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestApp.DesktopClient
{
    public class Startup
    {
        public static void ConfigureForm(Form1 form, UIFacade uiFacade)
        {
            form.comboBox1.DataSource = uiFacade.GetShapeListItems();
            form.buttonCalculateSquare.Enabled = false;
            form.buttonCheckRightTriangle.Enabled = false;

            form.comboBox1.SelectedValueChanged += (sender, args) => {
                HandleShapeListChange(form);
            };

            form.buttonCalculateSquare.Click += (sender, args) =>
            {
                HandleCalculateButtonClick(form, uiFacade);
            };

            form.buttonCreateShape.Click += (sender, args) =>
            {
                HandleCreateShapeButtonClick(form, uiFacade);
            };

            form.buttonCheckRightTriangle.Click += (sender, args) =>
            {
                HandleRightTriangleCheckButtonClick(form, uiFacade);
            };
        }

        static void HandleShapeListChange(Form1 form)
        {
            var selectedItem = form.comboBox1.SelectedItem as ShapeListItem;
            if (selectedItem != null)
            {
                var shape = selectedItem.Value;

                switch (shape)
                {
                    case ShapeType.Circle:
                        form.triangleOptionsArea.Visible = false;
                        form.circleOptionsArea.Visible = true;
                        break;
                    case ShapeType.Triangle:

                        form.circleOptionsArea.Visible = false;
                        form.triangleOptionsArea.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        static void HandleCalculateButtonClick(Form1 form, UIFacade uiFacade)
        {
            form.squareOutput.Text = uiFacade.CalculateSquare().ToString();
        }

        static void HandleCreateShapeButtonClick(Form1 form, UIFacade uiFacade)
        {
            var selectedItem = form.comboBox1.SelectedItem as ShapeListItem;
            if (selectedItem != null)
            {
                var shape = selectedItem.Value;

                switch (shape)
                {
                    case ShapeType.Circle:
                        uiFacade.CreateCircle(form.circleRadiusInput.Text);
                        if (uiFacade.Shape != null)
                        {
                            form.buttonCheckRightTriangle.Enabled = false;
                        }
                        break;
                    case ShapeType.Triangle:
                        uiFacade.CreateTriangle(form.triangleSideOneInput.Text, form.triangleSideTwoInput.Text, form.triangleSideThreeInput.Text);
                        if (uiFacade.Shape != null)
                        {
                            form.buttonCheckRightTriangle.Enabled = true;
                        }
                        break;
                    default:
                        break;
                }



                if (!string.IsNullOrWhiteSpace(uiFacade.ErrorMessage))
                {
                    MessageBox.Show(uiFacade.ErrorMessage);
                    return;
                }

                form.successMessageOutput.Text = uiFacade.SuccessMessage;
                form.buttonCalculateSquare.Enabled = true;
            }
        }

        static void HandleRightTriangleCheckButtonClick(Form1 form, UIFacade uiFacade)
        {
            form.rightTriangleOutput.Text = uiFacade.IsRightTriangle() ? "Right" : "Not Right";
        }
    }
}
