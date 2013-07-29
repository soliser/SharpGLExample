using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;

namespace SharpGLExample
{
    /// <summary>
    /// The main form class.
    /// </summary>
    public partial class SharpGLForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharpGLForm"/> class.
        /// </summary>
        public SharpGLForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the OpenGLDraw event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLDraw(object sender, PaintEventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Load the identity matrix.
            gl.LoadIdentity();

            //  Rotate around the Y axis.
            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            //  Draw a coloured pyramid.
            addTriangle(gl);
            //addCube(gl);

            addPlane(gl);

            //update the backgroud color using sliders
            gl.ClearColor(_bgRed, _bgGreen, _bgBlue, 0);

            //  Nudge the rotation.
            rotation += 2.0f;
        }

        //draw plane
        private void addPlane(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(_planeRed, _planeGreen, _planeBlue);
            gl.Vertex(-_planeXWidth, _planeYHeight, -_planeZDepth);
            gl.Vertex(-_planeXWidth, _planeYHeight, _planeZDepth);
            gl.Vertex(_planeXWidth, _planeYHeight, _planeZDepth);
            gl.Vertex(_planeXWidth, _planeYHeight, -_planeZDepth);
            gl.End();
        }


        //Draw a Triangle
        private void addTriangleMultiColor(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.End();
        }

        //Draw a Cube
        private void addCube(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            // front
            gl.Vertex(_shapeSize, _shapeSize, _shapeSize);
            gl.Vertex(_shapeSize, _shapeSize, _shapeSize);
            gl.Vertex(_shapeSize, _shapeSize, _shapeSize);
            gl.Vertex(_shapeSize, _shapeSize, _shapeSize);
            // back
            gl.Vertex(_shapeSize, -_shapeSize, _shapeSize);
            gl.Vertex(_shapeSize, _shapeSize, _shapeSize);
            gl.Vertex(-_shapeSize, _shapeSize, _shapeSize);
            gl.Vertex(-_shapeSize, -_shapeSize, _shapeSize);
            // right
            gl.Vertex(_shapeSize, -_shapeSize, -_shapeSize);
            gl.Vertex(_shapeSize, _shapeSize, -_shapeSize);
            gl.Vertex(_shapeSize, _shapeSize, _shapeSize);
            gl.Vertex(_shapeSize, -_shapeSize, _shapeSize);
            // left
            gl.Vertex(-_shapeSize, -_shapeSize, _shapeSize);
            gl.Vertex(-_shapeSize, _shapeSize, _shapeSize);
            gl.Vertex(-_shapeSize, _shapeSize, -_shapeSize);
            gl.Vertex(-_shapeSize, -_shapeSize, -_shapeSize);
            // top
            gl.Vertex(_shapeSize, _shapeSize, _shapeSize);
            gl.Vertex(_shapeSize, _shapeSize, -_shapeSize);
            gl.Vertex(-_shapeSize, _shapeSize, -_shapeSize);
            gl.Vertex(-_shapeSize, _shapeSize, _shapeSize);
            // bottom
            gl.Vertex(_shapeSize, -_shapeSize, -_shapeSize);
            gl.Vertex(_shapeSize, -_shapeSize, _shapeSize);
            gl.Vertex(-_shapeSize, -_shapeSize, _shapeSize);
            gl.Vertex(-_shapeSize, -_shapeSize, -_shapeSize);
            gl.End();
        }


        //Draw a Triangle
        private void addTriangle(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(0.0f, _shapeSize, 0.0f);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(-_shapeSize, -_shapeSize, _shapeSize);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(_shapeSize, -_shapeSize, _shapeSize);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(0.0f, _shapeSize, 0.0f);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(_shapeSize, -_shapeSize, _shapeSize);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(_shapeSize, -_shapeSize, -_shapeSize);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(0.0f, _shapeSize, 0.0f);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(_shapeSize, -_shapeSize, -_shapeSize);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(-_shapeSize, -_shapeSize, -_shapeSize);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(0.0f, _shapeSize, 0.0f);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(-_shapeSize, -_shapeSize, -_shapeSize);
            gl.Color(_shapeRed, _shapeGreen, _shapeBlue);
            gl.Vertex(-_shapeSize, -_shapeSize, _shapeSize);
            gl.End();
        }

        /// <summary>
        /// Handles the OpenGLInitialized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  TODO: Set the projection matrix here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            //  Create a perspective transformation.
            //gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);
            gl.Perspective(Math.PI / 2, (double)Width / (double)Height, 1, 64);

            //  Use the 'look at' helper function to position and aim the camera.
            //gl.LookAt(-10, 5, -10, 0, 0, 0, 0, 1, 0);
            gl.LookAt(0, 10, 10, 0, 0, 0, 0, 1, 0);

            //  Set the modelview matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        /// <summary>
        /// The current rotation.
        /// </summary>
        private float rotation = 0.0f;


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _bgRed = (float)trackBar1.Value / 100;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            _bgGreen = (float)trackBar2.Value / 100;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            _bgBlue = (float)trackBar3.Value/100;
        }
        
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            _shapeRed = (float)trackBar5.Value / 100;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            _shapeGreen = (float)trackBar6.Value / 100;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            _shapeBlue = (float)trackBar4.Value / 100;
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            _planeYHeight = (float)trackBar7.Value / 100; 
        }  

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            _shapeSize = (float) trackBar8.Value/1000;
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            _planeRed = (float)trackBar10.Value / 100;
        }

        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            _planeGreen = (float)trackBar11.Value / 100;
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            _planeBlue = (float)trackBar9.Value / 100;
        }
        private void trackBar12_Scroll(object sender, EventArgs e)
        {
            _planeXWidth = (float) trackBar12.Value/5000;
        }

        private void trackBar13_Scroll(object sender, EventArgs e)
        {
            _planeZDepth = (float)trackBar13.Value / 5000;
        }     
        private float _bgRed = 0;
        private float _bgGreen = 0;
        private float _bgBlue = 0;
        private float _shapeSize = 0;
        private float _shapeRed = 0;
        private float _shapeGreen = 0;
        private float _shapeBlue = 0;
        private float _planeYHeight = 0;
        private float _planeXWidth = 0;
        private float _planeZDepth = 0;
        private float _planeRed = 0;
        private float _planeGreen = 0;
        private float _planeBlue;


    }
}
