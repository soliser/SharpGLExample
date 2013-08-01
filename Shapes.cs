using SharpGL;

namespace SharpGLExample
{
    class Shapes
    {

        //draw plane
        public static void AddPlane(OpenGL gl, float planeRed, float planeGreen, float planeBlue, float planeXWidth, float planeYHeight, float planeZDepth)
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(planeRed, planeGreen, planeBlue);
            gl.Vertex(-planeXWidth, planeYHeight, -planeZDepth);
            gl.Vertex(-planeXWidth, planeYHeight, planeZDepth);
            gl.Vertex(planeXWidth, planeYHeight, planeZDepth);
            gl.Vertex(planeXWidth, planeYHeight, -planeZDepth);
            gl.End();
        }


        //Draw a Triangle
        private void AddTriangleMultiColor(OpenGL gl)
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
        private void AddCube(OpenGL gl, float shapeRed, float shapeGreen, float shapeBlue, float shapeSize)
        {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            // front
            gl.Vertex(shapeSize, shapeSize, shapeSize);
            gl.Vertex(shapeSize, shapeSize, shapeSize);
            gl.Vertex(shapeSize, shapeSize, shapeSize);
            gl.Vertex(shapeSize, shapeSize, shapeSize);
            // back
            gl.Vertex(shapeSize, -shapeSize, shapeSize);
            gl.Vertex(shapeSize, shapeSize, shapeSize);
            gl.Vertex(-shapeSize, shapeSize, shapeSize);
            gl.Vertex(-shapeSize, -shapeSize, shapeSize);
            // right
            gl.Vertex(shapeSize, -shapeSize, -shapeSize);
            gl.Vertex(shapeSize, shapeSize, -shapeSize);
            gl.Vertex(shapeSize, shapeSize, shapeSize);
            gl.Vertex(shapeSize, -shapeSize, shapeSize);
            // left
            gl.Vertex(-shapeSize, -shapeSize, shapeSize);
            gl.Vertex(-shapeSize, shapeSize, shapeSize);
            gl.Vertex(-shapeSize, shapeSize, -shapeSize);
            gl.Vertex(-shapeSize, -shapeSize, -shapeSize);
            // top
            gl.Vertex(shapeSize, shapeSize, shapeSize);
            gl.Vertex(shapeSize, shapeSize, -shapeSize);
            gl.Vertex(-shapeSize, shapeSize, -shapeSize);
            gl.Vertex(-shapeSize, shapeSize, shapeSize);
            // bottom
            gl.Vertex(shapeSize, -shapeSize, -shapeSize);
            gl.Vertex(shapeSize, -shapeSize, shapeSize);
            gl.Vertex(-shapeSize, -shapeSize, shapeSize);
            gl.Vertex(-shapeSize, -shapeSize, -shapeSize);
            gl.End();
        }


        //Draw a Triangle
        public static void AddTriangle(OpenGL gl, float shapeRed, float shapeGreen, float shapeBlue, float shapeSize)
        {
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(0.0f, shapeSize, 0.0f);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(-shapeSize, -shapeSize, shapeSize);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(shapeSize, -shapeSize, shapeSize);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(0.0f, shapeSize, 0.0f);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(shapeSize, -shapeSize, shapeSize);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(shapeSize, -shapeSize, -shapeSize);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(0.0f, shapeSize, 0.0f);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(shapeSize, -shapeSize, -shapeSize);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(-shapeSize, -shapeSize, -shapeSize);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(0.0f, shapeSize, 0.0f);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(-shapeSize, -shapeSize, -shapeSize);
            gl.Color(shapeRed, shapeGreen, shapeBlue);
            gl.Vertex(-shapeSize, -shapeSize, shapeSize);
            gl.End();
        }
    }
}
