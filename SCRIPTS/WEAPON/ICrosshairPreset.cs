namespace FIRS.UIModules.UIElements.Crosshair
{
    public interface ICrosshairPreset
    {
        /// <summary>
        /// Draw crosshair elements GUI layout taking into account hide state.
        /// </summary>
        /// <param name="spread"></param>
        void DrawElements(float spread);
    }
}