using System;
using System.ComponentModel;
using System.Diagnostics;

namespace UTimer.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public BreakForm m_BreakForm;

            public BreakForm BreakForm
            {
                [DebuggerHidden]
                get
                {
                    m_BreakForm = Create__Instance__(m_BreakForm);
                    return m_BreakForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BreakForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BreakForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BreakPausedForm m_BreakPausedForm;

            public BreakPausedForm BreakPausedForm
            {
                [DebuggerHidden]
                get
                {
                    m_BreakPausedForm = Create__Instance__(m_BreakPausedForm);
                    return m_BreakPausedForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BreakPausedForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BreakPausedForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MainForm m_MainForm;

            public MainForm MainForm
            {
                [DebuggerHidden]
                get
                {
                    m_MainForm = Create__Instance__(m_MainForm);
                    return m_MainForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MainForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MainForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SettingsForm m_SettingsForm;

            public SettingsForm SettingsForm
            {
                [DebuggerHidden]
                get
                {
                    m_SettingsForm = Create__Instance__(m_SettingsForm);
                    return m_SettingsForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SettingsForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SettingsForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SplashScreenForm m_SplashScreenForm;

            public SplashScreenForm SplashScreenForm
            {
                [DebuggerHidden]
                get
                {
                    m_SplashScreenForm = Create__Instance__(m_SplashScreenForm);
                    return m_SplashScreenForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SplashScreenForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SplashScreenForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public UnhandledExceptionForm m_UnhandledExceptionForm;

            public UnhandledExceptionForm UnhandledExceptionForm
            {
                [DebuggerHidden]
                get
                {
                    m_UnhandledExceptionForm = Create__Instance__(m_UnhandledExceptionForm);
                    return m_UnhandledExceptionForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_UnhandledExceptionForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UnhandledExceptionForm);
                }
            }
        }
    }
}