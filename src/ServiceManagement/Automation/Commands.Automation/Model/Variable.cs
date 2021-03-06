﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using Microsoft.Azure.Commands.Automation.Common;

namespace Microsoft.Azure.Commands.Automation.Model
{
    using AutomationManagement = Management.Automation;

    /// <summary>
    /// The Variable.
    /// </summary>
    public class Variable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class.
        /// </summary>
        /// <param name="variable">
        /// The varaiable.
        /// </param>
        /// <exception cref="System.ArgumentException">
        /// </exception>
        public Variable(AutomationManagement.Models.Variable variable, string automationAccoutName)
        {
            Requires.Argument("variable", variable).NotNull();

            this.Name = variable.Name;
            this.CreationTime = variable.Properties.CreationTime.ToLocalTime();
            this.LastModifiedTime = variable.Properties.LastModifiedTime.ToLocalTime();
            this.Value = variable.Properties.Value;
            this.Description = variable.Properties.Description;
            this.Encrypted = false;
            this.AutomationAccountName = automationAccoutName;
        }

        // <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class.
        /// </summary>
        /// <param name="variable">
        /// The variable.
        /// </param>
        /// <exception cref="System.ArgumentException">
        /// </exception>
        public Variable(AutomationManagement.Models.EncryptedVariable variable, string automationAccountName)
        {
            Requires.Argument("variable", variable).NotNull();

            this.Name = variable.Name;
            this.CreationTime = variable.Properties.CreationTime.ToLocalTime();
            this.LastModifiedTime = variable.Properties.LastModifiedTime.ToLocalTime();
            this.Value = null;
            this.Description = variable.Properties.Description;
            this.Encrypted = true;
            this.AutomationAccountName = automationAccountName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable"/> class.
        /// </summary>
        public Variable()
        {
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        public DateTimeOffset CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        public DateTimeOffset LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public bool Encrypted { get; set; }

        /// <summary>
        /// Gets or sets the automation account name.
        /// </summary>
        public string AutomationAccountName { get; set; }
    }
}
