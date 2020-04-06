using System;
using SharpGL;
using SharpGL.SceneGraph;

namespace OpenGlWpf1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGLControl_OnOpenGLDraw(object sender, OpenGLEventArgs args)
        {
            throw new NotImplementedException();
        }

        private void OpenGlControl_OpenGlInitialized(object sender, OpenGLEventArgs args)
        {
            OpenGL gl = args.OpenGL;
        }
    }
}
