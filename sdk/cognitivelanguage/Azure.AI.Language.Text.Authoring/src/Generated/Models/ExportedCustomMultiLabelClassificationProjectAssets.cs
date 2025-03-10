// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring.Models
{
    /// <summary> Represents the exported assets for a custom multi-label classification project. </summary>
    public partial class ExportedCustomMultiLabelClassificationProjectAssets : ExportedProjectAssets
    {
        /// <summary> Initializes a new instance of <see cref="ExportedCustomMultiLabelClassificationProjectAssets"/>. </summary>
        public ExportedCustomMultiLabelClassificationProjectAssets()
        {
            ProjectKind = ProjectKind.CustomMultiLabelClassification;
            Classes = new ChangeTrackingList<ExportedClass>();
            Documents = new ChangeTrackingList<ExportedCustomMultiLabelClassificationDocument>();
        }

        /// <summary> Initializes a new instance of <see cref="ExportedCustomMultiLabelClassificationProjectAssets"/>. </summary>
        /// <param name="projectKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="classes"> The list of classes in the project. </param>
        /// <param name="documents"> The list of documents in the project. </param>
        internal ExportedCustomMultiLabelClassificationProjectAssets(ProjectKind projectKind, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<ExportedClass> classes, IList<ExportedCustomMultiLabelClassificationDocument> documents) : base(projectKind, serializedAdditionalRawData)
        {
            Classes = classes;
            Documents = documents;
        }

        /// <summary> The list of classes in the project. </summary>
        public IList<ExportedClass> Classes { get; }
        /// <summary> The list of documents in the project. </summary>
        public IList<ExportedCustomMultiLabelClassificationDocument> Documents { get; }
    }
}
