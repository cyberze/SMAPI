﻿using System;

namespace StardewModdingAPI.Events
{
    public static class GameEvents
    {
        public static event EventHandler GameLoaded = delegate { };
        public static event EventHandler Initialize = delegate { };
        public static event EventHandler LoadContent = delegate { };
        public static event EventHandler FirstUpdateTick = delegate { };

        /// <summary>
        ///     Fires every update (1/60 of a second)
        /// </summary>
        public static event EventHandler UpdateTick = delegate { };

        /// <summary>
        ///     Fires every other update (1/30 of a second)
        /// </summary>
        public static event EventHandler SecondUpdateTick = delegate { };

        /// <summary>
        ///     Fires every fourth update (1/15 of a second)
        /// </summary>
        public static event EventHandler FourthUpdateTick = delegate { };

        /// <summary>
        ///     Fires every eighth update (roughly 1/8 of a second)
        /// </summary>
        public static event EventHandler EighthUpdateTick = delegate { };

        /// <summary>
        ///     Fires every fifthteenth update (1/4 of a second)
        /// </summary>
        public static event EventHandler QuarterSecondTick = delegate { };

        /// <summary>
        ///     Fires every thirtieth update (1/2 of a second)
        /// </summary>
        public static event EventHandler HalfSecondTick = delegate { };

        /// <summary>
        ///     Fires every sixtieth update (a second)
        /// </summary>
        public static event EventHandler OneSecondTick = delegate { };

        public static void InvokeGameLoaded()
        {
            GameLoaded.Invoke(null, EventArgs.Empty);
        }

        public static void InvokeInitialize()
        {
            try
            {
                Initialize.Invoke(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Log.AsyncR("An exception occured in XNA Initialize: " + ex);
            }
        }

        public static void InvokeLoadContent()
        {
            try
            {
                LoadContent.Invoke(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Log.AsyncR("An exception occured in XNA LoadContent: " + ex);
            }
        }

        public static void InvokeUpdateTick()
        {
            try
            {
                UpdateTick.Invoke(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Log.AsyncR("An exception occured in XNA UpdateTick: " + ex);
            }
        }

        public static void InvokeSecondUpdateTick()
        {
            SecondUpdateTick.Invoke(null, EventArgs.Empty);
        }

        public static void InvokeFourthUpdateTick()
        {
            FourthUpdateTick.Invoke(null, EventArgs.Empty);
        }

        public static void InvokeEighthUpdateTick()
        {
            EighthUpdateTick.Invoke(null, EventArgs.Empty);
        }

        public static void InvokeQuarterSecondTick()
        {
            QuarterSecondTick.Invoke(null, EventArgs.Empty);
        }

        public static void InvokeHalfSecondTick()
        {
            HalfSecondTick.Invoke(null, EventArgs.Empty);
        }

        public static void InvokeOneSecondTick()
        {
            OneSecondTick.Invoke(null, EventArgs.Empty);
        }

        public static void InvokeFirstUpdateTick()
        {
            FirstUpdateTick.Invoke(null, EventArgs.Empty);
        }
    }
}