/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace animal
{
    #region AnimalState Class
    #if (!OPCUA_EXCLUDE_AnimalState)
    /// <summary>
    /// Stores an instance of the AnimalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnimalState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnimalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(animal.ObjectTypes.AnimalType, animal.Namespaces.animal, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwczovL29wY3VhLnJvY2tzL1VBL2FuaW1hbC//////hGCAAgEAAAABABIAAABBbmlt" +
           "YWxUeXBlSW5zdGFuY2UBAZk6AQGZOpk6AAAB/////wEAAAA1YIkKAgAAAAEABAAAAE5hbWUBAZo6AwAA" +
           "AAASAAAATmFtZSBvZiB0aGUgYW5pbWFsAC4ARJo6AAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case animal.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<string>(this);
                            }
                            else
                            {
                                Name = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_name;
        #endregion
    }
    #endif
    #endregion

    #region MammalState Class
    #if (!OPCUA_EXCLUDE_MammalState)
    /// <summary>
    /// Stores an instance of the MammalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MammalState : AnimalState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MammalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(animal.ObjectTypes.MammalType, animal.Namespaces.animal, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Sound != null)
            {
                Sound.Initialize(context, Sound_InitializationString);
            }
        }

        #region Initialization String
        private const string Sound_InitializationString =
           "AQAAAB4AAABodHRwczovL29wY3VhLnJvY2tzL1VBL2FuaW1hbC//////NWCJCgIAAAABAAUAAABTb3Vu" +
           "ZAEBpToDAAAAABoAAABUaGUgc291bmQgdGhlIGFuaW1hbCBtYWtlcwAvAQGuOqU6AAABAbE6/////wEB" +
           "/////wEAAAA1YIkKAgAAAAEABAAAAFZlcmIBAaY6AwAAAAAgAAAAVmVyYiBkZXNjcmliaW5nIHRoZSBh" +
           "bmltYWwgc291bmQALwA/pjoAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB4AAABodHRwczovL29wY3VhLnJvY2tzL1VBL2FuaW1hbC//////hGCAAgEAAAABABIAAABNYW1t" +
           "YWxUeXBlSW5zdGFuY2UBAZs6AQGbOps6AAAB/////wMAAAA1YIkKAgAAAAEABAAAAE5hbWUBAZw6AwAA" +
           "AAASAAAATmFtZSBvZiB0aGUgYW5pbWFsAC4ARJw6AAAADP////8BAf////8AAAAANWCJCgIAAAABAAgA" +
           "AABMZWdDb3VudAEBnToDAAAAAB0AAABOdW1iZXIgb2YgbGVncyB0aGUgYW5pbWFsIGhhcwAuAESdOgAA" +
           "AAf/////AQH/////AAAAADVgiQoCAAAAAQAFAAAAU291bmQBAaU6AwAAAAAaAAAAVGhlIHNvdW5kIHRo" +
           "ZSBhbmltYWwgbWFrZXMALwEBrjqlOgAAAQGxOv////8BAf////8BAAAANWCJCgIAAAABAAQAAABWZXJi" +
           "AQGmOgMAAAAAIAAAAFZlcmIgZGVzY3JpYmluZyB0aGUgYW5pbWFsIHNvdW5kAC8AP6Y6AAAADP////8B" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> LegCount
        {
            get
            {
                return m_legCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_legCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_legCount = value;
            }
        }

        /// <remarks />
        public AnimalSoundState Sound
        {
            get
            {
                return m_sound;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sound, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sound = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_legCount != null)
            {
                children.Add(m_legCount);
            }

            if (m_sound != null)
            {
                children.Add(m_sound);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case animal.BrowseNames.LegCount:
                {
                    if (createOrReplace)
                    {
                        if (LegCount == null)
                        {
                            if (replacement == null)
                            {
                                LegCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                LegCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = LegCount;
                    break;
                }

                case animal.BrowseNames.Sound:
                {
                    if (createOrReplace)
                    {
                        if (Sound == null)
                        {
                            if (replacement == null)
                            {
                                Sound = new AnimalSoundState(this);
                            }
                            else
                            {
                                Sound = (AnimalSoundState)replacement;
                            }
                        }
                    }

                    instance = Sound;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<uint> m_legCount;
        private AnimalSoundState m_sound;
        #endregion
    }
    #endif
    #endregion

    #region CatState Class
    #if (!OPCUA_EXCLUDE_CatState)
    /// <summary>
    /// Stores an instance of the CatType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CatState : MammalState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CatState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(animal.ObjectTypes.CatType, animal.Namespaces.animal, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB4AAABodHRwczovL29wY3VhLnJvY2tzL1VBL2FuaW1hbC//////hGCAAgEAAAABAA8AAABDYXRU" +
           "eXBlSW5zdGFuY2UBAZ46AQGeOp46AAAB/////wIAAAA1YIkKAgAAAAEABAAAAE5hbWUBAZ86AwAAAAAS" +
           "AAAATmFtZSBvZiB0aGUgYW5pbWFsAC4ARJ86AAAADP////8BAf////8AAAAANWCJCgIAAAABAAgAAABM" +
           "ZWdDb3VudAEBoDoDAAAAAB0AAABOdW1iZXIgb2YgbGVncyB0aGUgYW5pbWFsIGhhcwAuAESgOgAAAAf/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DogState Class
    #if (!OPCUA_EXCLUDE_DogState)
    /// <summary>
    /// Stores an instance of the DogType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DogState : MammalState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DogState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(animal.ObjectTypes.DogType, animal.Namespaces.animal, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Weight != null)
            {
                Weight.Initialize(context, Weight_InitializationString);
            }
        }

        #region Initialization String
        private const string Weight_InitializationString =
           "AQAAAB4AAABodHRwczovL29wY3VhLnJvY2tzL1VBL2FuaW1hbC//////NWCJCgIAAAABAAYAAABXZWln" +
           "aHQBAaQ6AwAAAAAXAAAAV2VpZ2h0IG9mIHRoZSBkb2cgaW4gS0cALgBEpDoAAAAL/////wEB/////wAA" +
           "AAA=";

        private const string InitializationString =
           "AQAAAB4AAABodHRwczovL29wY3VhLnJvY2tzL1VBL2FuaW1hbC//////hGCAAgEAAAABAA8AAABEb2dU" +
           "eXBlSW5zdGFuY2UBAaE6AQGhOqE6AAAB/////wMAAAA1YIkKAgAAAAEABAAAAE5hbWUBAaI6AwAAAAAS" +
           "AAAATmFtZSBvZiB0aGUgYW5pbWFsAC4ARKI6AAAADP////8BAf////8AAAAANWCJCgIAAAABAAgAAABM" +
           "ZWdDb3VudAEBozoDAAAAAB0AAABOdW1iZXIgb2YgbGVncyB0aGUgYW5pbWFsIGhhcwAuAESjOgAAAAf/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAGAAAAV2VpZ2h0AQGkOgMAAAAAFwAAAFdlaWdodCBvZiB0aGUg" +
           "ZG9nIGluIEtHAC4ARKQ6AAAAC/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<double> Weight
        {
            get
            {
                return m_weight;
            }

            set
            {
                if (!Object.ReferenceEquals(m_weight, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_weight = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_weight != null)
            {
                children.Add(m_weight);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case animal.BrowseNames.Weight:
                {
                    if (createOrReplace)
                    {
                        if (Weight == null)
                        {
                            if (replacement == null)
                            {
                                Weight = new PropertyState<double>(this);
                            }
                            else
                            {
                                Weight = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Weight;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<double> m_weight;
        #endregion
    }
    #endif
    #endregion

    #region AnimalSoundState Class
    #if (!OPCUA_EXCLUDE_AnimalSoundState)
    /// <summary>
    /// Stores an instance of the AnimalSoundType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnimalSoundState : BaseDataVariableState<AnimalSound>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnimalSoundState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(animal.VariableTypes.AnimalSoundType, animal.Namespaces.animal, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(animal.DataTypes.AnimalSound, animal.Namespaces.animal, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (AudioFile != null)
            {
                AudioFile.Initialize(context, AudioFile_InitializationString);
            }
        }

        #region Initialization String
        private const string AudioFile_InitializationString =
           "AQAAAB4AAABodHRwczovL29wY3VhLnJvY2tzL1VBL2FuaW1hbC//////NWCJCgIAAAABAAkAAABBdWRp" +
           "b0ZpbGUBAbA6AwAAAAAiAAAAVVJMIHRvIGFuIGF1ZGlvIGZpbGUgZm9yIHRoZSBzb3VuZAAvAD+wOgAA" +
           "AAz/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB4AAABodHRwczovL29wY3VhLnJvY2tzL1VBL2FuaW1hbC//////FWCJAgIAAAABABcAAABBbmlt" +
           "YWxTb3VuZFR5cGVJbnN0YW5jZQEBrjoBAa46rjoAAAEBsTr/////AQH/////AgAAADVgiQoCAAAAAQAE" +
           "AAAAVmVyYgEBrzoDAAAAACAAAABWZXJiIGRlc2NyaWJpbmcgdGhlIGFuaW1hbCBzb3VuZAAvAD+vOgAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAQAJAAAAQXVkaW9GaWxlAQGwOgMAAAAAIgAAAFVSTCB0byBh" +
           "biBhdWRpbyBmaWxlIGZvciB0aGUgc291bmQALwA/sDoAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<string> Verb
        {
            get
            {
                return m_verb;
            }

            set
            {
                if (!Object.ReferenceEquals(m_verb, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_verb = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> AudioFile
        {
            get
            {
                return m_audioFile;
            }

            set
            {
                if (!Object.ReferenceEquals(m_audioFile, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_audioFile = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_verb != null)
            {
                children.Add(m_verb);
            }

            if (m_audioFile != null)
            {
                children.Add(m_audioFile);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case animal.BrowseNames.Verb:
                {
                    if (createOrReplace)
                    {
                        if (Verb == null)
                        {
                            if (replacement == null)
                            {
                                Verb = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Verb = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Verb;
                    break;
                }

                case animal.BrowseNames.AudioFile:
                {
                    if (createOrReplace)
                    {
                        if (AudioFile == null)
                        {
                            if (replacement == null)
                            {
                                AudioFile = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                AudioFile = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = AudioFile;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_verb;
        private BaseDataVariableState<string> m_audioFile;
        #endregion
    }

    #region AnimalSoundValue Class
    /// <summary>
    /// A typed version of the _BrowseName_ variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AnimalSoundValue : BaseVariableValue
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AnimalSoundValue(AnimalSoundState variable, AnimalSound value, object dataLock) : base(dataLock)
        {
            m_value = value;

            if (m_value == null)
            {
                m_value = new AnimalSound();
            }

            Initialize(variable);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The variable that the value belongs to.
        /// </summary>
        public AnimalSoundState Variable
        {
            get { return m_variable; }
        }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        public AnimalSound Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Initializes the object.
        /// </summary>
        private void Initialize(AnimalSoundState variable)
        {
            lock (Lock)
            {
                m_variable = variable;

                variable.Value = m_value;

                variable.OnReadValue = OnReadValue;
                variable.OnSimpleWriteValue = OnWriteValue;

                BaseVariableState instance = null;
                List<BaseInstanceState> updateList = new List<BaseInstanceState>();
                updateList.Add(variable);

                instance = m_variable.Verb;
                instance.OnReadValue = OnRead_Verb;
                instance.OnSimpleWriteValue = OnWrite_Verb;
                updateList.Add(instance);
                instance = m_variable.AudioFile;
                instance.OnReadValue = OnRead_AudioFile;
                instance.OnSimpleWriteValue = OnWrite_AudioFile;
                updateList.Add(instance);

                SetUpdateList(updateList);
            }
        }

        /// <summary>
        /// Reads the value of the variable.
        /// </summary>
        protected ServiceResult OnReadValue(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable.
        /// </summary>
        private ServiceResult OnWriteValue(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value = (AnimalSound)Write(value);
            }

            return ServiceResult.Good;
        }

        #region Verb Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_Verb(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value.Verb;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_Verb(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.Verb = (string)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion

        #region AudioFile Access Methods
        /// <summary>
        /// Reads the value of the variable child.
        /// </summary>
        private ServiceResult OnRead_AudioFile(
            ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            lock (Lock)
            {
                DoBeforeReadProcessing(context, node);

                if (m_value != null)
                {
                    value = m_value.AudioFile;
                }

                return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
            }
        }

        /// <summary>
        /// Writes the value of the variable child.
        /// </summary>
        private ServiceResult OnWrite_AudioFile(ISystemContext context, NodeState node, ref object value)
        {
            lock (Lock)
            {
                m_value.AudioFile = (string)Write(value);
            }

            return ServiceResult.Good;
        }
        #endregion
        #endregion

        #region Private Fields
        private AnimalSound m_value;
        private AnimalSoundState m_variable;
        #endregion
    }
    #endregion
    #endif
    #endregion
}