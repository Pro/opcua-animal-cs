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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace animal
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the AnimalSound DataType.
        /// </summary>
        public const uint AnimalSound = 15025;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the AnimalSet Object.
        /// </summary>
        public const uint AnimalSet = 15043;

        /// <summary>
        /// The identifier for the Cat Object.
        /// </summary>
        public const uint Cat = 15044;

        /// <summary>
        /// The identifier for the Dog Object.
        /// </summary>
        public const uint Dog = 15050;

        /// <summary>
        /// The identifier for the AnimalSound_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint AnimalSound_Encoding_DefaultBinary = 15026;

        /// <summary>
        /// The identifier for the AnimalSound_Encoding_DefaultXml Object.
        /// </summary>
        public const uint AnimalSound_Encoding_DefaultXml = 15034;

        /// <summary>
        /// The identifier for the AnimalSound_Encoding_DefaultJson Object.
        /// </summary>
        public const uint AnimalSound_Encoding_DefaultJson = 15042;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the AnimalType ObjectType.
        /// </summary>
        public const uint AnimalType = 15001;

        /// <summary>
        /// The identifier for the MammalType ObjectType.
        /// </summary>
        public const uint MammalType = 15003;

        /// <summary>
        /// The identifier for the CatType ObjectType.
        /// </summary>
        public const uint CatType = 15006;

        /// <summary>
        /// The identifier for the DogType ObjectType.
        /// </summary>
        public const uint DogType = 15009;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the AnimalType_Name Variable.
        /// </summary>
        public const uint AnimalType_Name = 15002;

        /// <summary>
        /// The identifier for the MammalType_LegCount Variable.
        /// </summary>
        public const uint MammalType_LegCount = 15005;

        /// <summary>
        /// The identifier for the MammalType_Sound Variable.
        /// </summary>
        public const uint MammalType_Sound = 15013;

        /// <summary>
        /// The identifier for the MammalType_Sound_Verb Variable.
        /// </summary>
        public const uint MammalType_Sound_Verb = 15014;

        /// <summary>
        /// The identifier for the CatType_Sound_Verb Variable.
        /// </summary>
        public const uint CatType_Sound_Verb = 15017;

        /// <summary>
        /// The identifier for the DogType_Sound_Verb Variable.
        /// </summary>
        public const uint DogType_Sound_Verb = 15020;

        /// <summary>
        /// The identifier for the DogType_Weight Variable.
        /// </summary>
        public const uint DogType_Weight = 15012;

        /// <summary>
        /// The identifier for the AnimalSoundType_Verb Variable.
        /// </summary>
        public const uint AnimalSoundType_Verb = 15023;

        /// <summary>
        /// The identifier for the AnimalSoundType_AudioFile Variable.
        /// </summary>
        public const uint AnimalSoundType_AudioFile = 15024;

        /// <summary>
        /// The identifier for the Cat_Name Variable.
        /// </summary>
        public const uint Cat_Name = 15045;

        /// <summary>
        /// The identifier for the Cat_LegCount Variable.
        /// </summary>
        public const uint Cat_LegCount = 15046;

        /// <summary>
        /// The identifier for the Cat_Sound_Verb Variable.
        /// </summary>
        public const uint Cat_Sound_Verb = 15048;

        /// <summary>
        /// The identifier for the Dog_Name Variable.
        /// </summary>
        public const uint Dog_Name = 15051;

        /// <summary>
        /// The identifier for the Dog_LegCount Variable.
        /// </summary>
        public const uint Dog_LegCount = 15052;

        /// <summary>
        /// The identifier for the Dog_Sound Variable.
        /// </summary>
        public const uint Dog_Sound = 15053;

        /// <summary>
        /// The identifier for the Dog_Sound_Verb Variable.
        /// </summary>
        public const uint Dog_Sound_Verb = 15054;

        /// <summary>
        /// The identifier for the animal_BinarySchema Variable.
        /// </summary>
        public const uint animal_BinarySchema = 15027;

        /// <summary>
        /// The identifier for the animal_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint animal_BinarySchema_NamespaceUri = 15029;

        /// <summary>
        /// The identifier for the animal_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint animal_BinarySchema_Deprecated = 15030;

        /// <summary>
        /// The identifier for the animal_BinarySchema_AnimalSound Variable.
        /// </summary>
        public const uint animal_BinarySchema_AnimalSound = 15031;

        /// <summary>
        /// The identifier for the animal_XmlSchema Variable.
        /// </summary>
        public const uint animal_XmlSchema = 15035;

        /// <summary>
        /// The identifier for the animal_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint animal_XmlSchema_NamespaceUri = 15037;

        /// <summary>
        /// The identifier for the animal_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint animal_XmlSchema_Deprecated = 15038;

        /// <summary>
        /// The identifier for the animal_XmlSchema_AnimalSound Variable.
        /// </summary>
        public const uint animal_XmlSchema_AnimalSound = 15039;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the AnimalSoundType VariableType.
        /// </summary>
        public const uint AnimalSoundType = 15022;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the AnimalSound DataType.
        /// </summary>
        public static readonly ExpandedNodeId AnimalSound = new ExpandedNodeId(animal.DataTypes.AnimalSound, animal.Namespaces.animal);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the AnimalSet Object.
        /// </summary>
        public static readonly ExpandedNodeId AnimalSet = new ExpandedNodeId(animal.Objects.AnimalSet, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Cat Object.
        /// </summary>
        public static readonly ExpandedNodeId Cat = new ExpandedNodeId(animal.Objects.Cat, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Dog Object.
        /// </summary>
        public static readonly ExpandedNodeId Dog = new ExpandedNodeId(animal.Objects.Dog, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the AnimalSound_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId AnimalSound_Encoding_DefaultBinary = new ExpandedNodeId(animal.Objects.AnimalSound_Encoding_DefaultBinary, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the AnimalSound_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId AnimalSound_Encoding_DefaultXml = new ExpandedNodeId(animal.Objects.AnimalSound_Encoding_DefaultXml, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the AnimalSound_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId AnimalSound_Encoding_DefaultJson = new ExpandedNodeId(animal.Objects.AnimalSound_Encoding_DefaultJson, animal.Namespaces.animal);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the AnimalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnimalType = new ExpandedNodeId(animal.ObjectTypes.AnimalType, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the MammalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MammalType = new ExpandedNodeId(animal.ObjectTypes.MammalType, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the CatType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CatType = new ExpandedNodeId(animal.ObjectTypes.CatType, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the DogType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DogType = new ExpandedNodeId(animal.ObjectTypes.DogType, animal.Namespaces.animal);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the AnimalType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnimalType_Name = new ExpandedNodeId(animal.Variables.AnimalType_Name, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the MammalType_LegCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId MammalType_LegCount = new ExpandedNodeId(animal.Variables.MammalType_LegCount, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the MammalType_Sound Variable.
        /// </summary>
        public static readonly ExpandedNodeId MammalType_Sound = new ExpandedNodeId(animal.Variables.MammalType_Sound, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the MammalType_Sound_Verb Variable.
        /// </summary>
        public static readonly ExpandedNodeId MammalType_Sound_Verb = new ExpandedNodeId(animal.Variables.MammalType_Sound_Verb, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the CatType_Sound_Verb Variable.
        /// </summary>
        public static readonly ExpandedNodeId CatType_Sound_Verb = new ExpandedNodeId(animal.Variables.CatType_Sound_Verb, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the DogType_Sound_Verb Variable.
        /// </summary>
        public static readonly ExpandedNodeId DogType_Sound_Verb = new ExpandedNodeId(animal.Variables.DogType_Sound_Verb, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the DogType_Weight Variable.
        /// </summary>
        public static readonly ExpandedNodeId DogType_Weight = new ExpandedNodeId(animal.Variables.DogType_Weight, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the AnimalSoundType_Verb Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnimalSoundType_Verb = new ExpandedNodeId(animal.Variables.AnimalSoundType_Verb, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the AnimalSoundType_AudioFile Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnimalSoundType_AudioFile = new ExpandedNodeId(animal.Variables.AnimalSoundType_AudioFile, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Cat_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId Cat_Name = new ExpandedNodeId(animal.Variables.Cat_Name, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Cat_LegCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId Cat_LegCount = new ExpandedNodeId(animal.Variables.Cat_LegCount, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Cat_Sound_Verb Variable.
        /// </summary>
        public static readonly ExpandedNodeId Cat_Sound_Verb = new ExpandedNodeId(animal.Variables.Cat_Sound_Verb, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Dog_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId Dog_Name = new ExpandedNodeId(animal.Variables.Dog_Name, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Dog_LegCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId Dog_LegCount = new ExpandedNodeId(animal.Variables.Dog_LegCount, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Dog_Sound Variable.
        /// </summary>
        public static readonly ExpandedNodeId Dog_Sound = new ExpandedNodeId(animal.Variables.Dog_Sound, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the Dog_Sound_Verb Variable.
        /// </summary>
        public static readonly ExpandedNodeId Dog_Sound_Verb = new ExpandedNodeId(animal.Variables.Dog_Sound_Verb, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the animal_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId animal_BinarySchema = new ExpandedNodeId(animal.Variables.animal_BinarySchema, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the animal_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId animal_BinarySchema_NamespaceUri = new ExpandedNodeId(animal.Variables.animal_BinarySchema_NamespaceUri, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the animal_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId animal_BinarySchema_Deprecated = new ExpandedNodeId(animal.Variables.animal_BinarySchema_Deprecated, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the animal_BinarySchema_AnimalSound Variable.
        /// </summary>
        public static readonly ExpandedNodeId animal_BinarySchema_AnimalSound = new ExpandedNodeId(animal.Variables.animal_BinarySchema_AnimalSound, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the animal_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId animal_XmlSchema = new ExpandedNodeId(animal.Variables.animal_XmlSchema, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the animal_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId animal_XmlSchema_NamespaceUri = new ExpandedNodeId(animal.Variables.animal_XmlSchema_NamespaceUri, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the animal_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId animal_XmlSchema_Deprecated = new ExpandedNodeId(animal.Variables.animal_XmlSchema_Deprecated, animal.Namespaces.animal);

        /// <summary>
        /// The identifier for the animal_XmlSchema_AnimalSound Variable.
        /// </summary>
        public static readonly ExpandedNodeId animal_XmlSchema_AnimalSound = new ExpandedNodeId(animal.Variables.animal_XmlSchema_AnimalSound, animal.Namespaces.animal);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the AnimalSoundType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AnimalSoundType = new ExpandedNodeId(animal.VariableTypes.AnimalSoundType, animal.Namespaces.animal);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the animal_BinarySchema component.
        /// </summary>
        public const string animal_BinarySchema = "animal";

        /// <summary>
        /// The BrowseName for the animal_XmlSchema component.
        /// </summary>
        public const string animal_XmlSchema = "animal";

        /// <summary>
        /// The BrowseName for the AnimalSet component.
        /// </summary>
        public const string AnimalSet = "AnimalSet";

        /// <summary>
        /// The BrowseName for the AnimalSound component.
        /// </summary>
        public const string AnimalSound = "AnimalSound";

        /// <summary>
        /// The BrowseName for the AnimalSoundType component.
        /// </summary>
        public const string AnimalSoundType = "AnimalSoundType";

        /// <summary>
        /// The BrowseName for the AnimalType component.
        /// </summary>
        public const string AnimalType = "AnimalType";

        /// <summary>
        /// The BrowseName for the AudioFile component.
        /// </summary>
        public const string AudioFile = "AudioFile";

        /// <summary>
        /// The BrowseName for the Cat component.
        /// </summary>
        public const string Cat = "Cat";

        /// <summary>
        /// The BrowseName for the CatType component.
        /// </summary>
        public const string CatType = "CatType";

        /// <summary>
        /// The BrowseName for the Dog component.
        /// </summary>
        public const string Dog = "Dog";

        /// <summary>
        /// The BrowseName for the DogType component.
        /// </summary>
        public const string DogType = "DogType";

        /// <summary>
        /// The BrowseName for the LegCount component.
        /// </summary>
        public const string LegCount = "LegCount";

        /// <summary>
        /// The BrowseName for the MammalType component.
        /// </summary>
        public const string MammalType = "MammalType";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the Sound component.
        /// </summary>
        public const string Sound = "Sound";

        /// <summary>
        /// The BrowseName for the Verb component.
        /// </summary>
        public const string Verb = "Verb";

        /// <summary>
        /// The BrowseName for the Weight component.
        /// </summary>
        public const string Weight = "Weight";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the animal namespace (.NET code namespace is 'animal').
        /// </summary>
        public const string animal = "https://opcua.rocks/UA/animal/";

        /// <summary>
        /// The URI for the animalXsd namespace (.NET code namespace is 'animal').
        /// </summary>
        public const string animalXsd = "https://opcua.rocks/UA/animal/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}