﻿#region Using Statements
    using System;
    using System.Collections.ObjectModel;

    using Cake.Core;
    using Cake.Core.IO;
    using Cake.Core.Annotations;

    using System.Management.Automation;
#endregion



namespace Cake.Powershell
{
    [CakeAliasCategory("Powershell")]
    public static class CakeAliases
    {
        /// <summary>
        /// Starts a powershell script using the specified information.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="script">The powershell script to run.</param>
        /// <returns>A collection of powershell objects</returns>
        [CakeMethodAlias]
        public static Collection<PSObject> StartPowershellScript(this ICakeContext context, string script)
        {
            return new PowershellRunner(context.Environment, context.Log).Start(script, new PowershellSettings());
        }

        /// <summary>
        /// Starts a powershell script using the specified information.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="script">The powershell script to run.</param>
        /// <param name="settings">The information about the script to start.</param>
        /// <returns>A collection of powershell objects</returns>
        [CakeMethodAlias]
        public static Collection<PSObject> StartPowershellScript(this ICakeContext context, string script, PowershellSettings settings)
        {
            return new PowershellRunner(context.Environment, context.Log).Start(script, settings);
        }



        /// <summary>
        /// Starts a powershell script using the specified information.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="path">The path of the script file to run.</param>
        /// <returns>A collection of powershell objects</returns>
        [CakeMethodAlias]
        public static Collection<PSObject> StartPowershellFile(this ICakeContext context, FilePath path)
        {
            return new PowershellRunner(context.Environment, context.Log).Start(path, new PowershellSettings());
        }

        /// <summary>
        /// Starts a powershell script using the specified information.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="path">The path of the script file to run.</param>
        /// <param name="settings">The information about the script to start.</param>
        /// <returns>A collection of powershell objects</returns>
        [CakeMethodAlias]
        public static Collection<PSObject> StartPowershellFile(this ICakeContext context, FilePath path, PowershellSettings settings)
        {
            return new PowershellRunner(context.Environment, context.Log).Start(path, settings);
        }



        /// <summary>
        /// Starts a powershell script using the specified information.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="uri">The location of the script file to download and run.</param>
        /// <returns>A collection of powershell objects</returns>
        [CakeMethodAlias]
        public static Collection<PSObject> StartPowershellDownload(this ICakeContext context, Uri uri, FilePath path)
        {
            return new PowershellRunner(context.Environment, context.Log).Start(uri, path, new PowershellSettings());
        }

        /// <summary>
        /// Starts a powershell script using the specified information.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="uri">The location of the script file to download and run.</param>
        /// <param name="settings">The information about the script to start.</param>
        /// <returns>A collection of powershell objects</returns>
        [CakeMethodAlias]
        public static Collection<PSObject> StartPowershellDownload(this ICakeContext context, Uri uri, FilePath path, PowershellSettings settings)
        {
            return new PowershellRunner(context.Environment, context.Log).Start(uri, path, settings);
        }
    }
}