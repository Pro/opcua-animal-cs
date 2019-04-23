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
    #region AnimalSound Class
    #if (!OPCUA_EXCLUDE_AnimalSound)
    /// <summary>
    /// Sound of an animal
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = animal.Namespaces.animalXsd)]
    public partial class AnimalSound : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public AnimalSound()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_verb = null;
            m_audioFile = null;
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "Verb", IsRequired = false, Order = 1)]
        public string Verb
        {
            get { return m_verb;  }
            set { m_verb = value; }
        }

        /// <remarks />
        [DataMember(Name = "AudioFile", IsRequired = false, Order = 2)]
        public string AudioFile
        {
            get { return m_audioFile;  }
            set { m_audioFile = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.AnimalSound; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.AnimalSound_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.AnimalSound_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(animal.Namespaces.animalXsd);

            encoder.WriteString("Verb", Verb);
            encoder.WriteString("AudioFile", AudioFile);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(animal.Namespaces.animalXsd);

            Verb = decoder.ReadString("Verb");
            AudioFile = decoder.ReadString("AudioFile");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AnimalSound value = encodeable as AnimalSound;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_verb, value.m_verb)) return false;
            if (!Utils.IsEqual(m_audioFile, value.m_audioFile)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (AnimalSound)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AnimalSound clone = (AnimalSound)base.MemberwiseClone();

            clone.m_verb = (string)Utils.Clone(this.m_verb);
            clone.m_audioFile = (string)Utils.Clone(this.m_audioFile);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_verb;
        private string m_audioFile;
        #endregion
    }

    #region AnimalSoundCollection Class
    /// <summary>
    /// A collection of AnimalSound objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAnimalSound", Namespace = animal.Namespaces.animalXsd, ItemName = "AnimalSound")]
    #if !NET_STANDARD
    public partial class AnimalSoundCollection : List<AnimalSound>, ICloneable
    #else
    public partial class AnimalSoundCollection : List<AnimalSound>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AnimalSoundCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AnimalSoundCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AnimalSoundCollection(IEnumerable<AnimalSound> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AnimalSoundCollection(AnimalSound[] values)
        {
            if (values != null)
            {
                return new AnimalSoundCollection(values);
            }

            return new AnimalSoundCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AnimalSound[](AnimalSoundCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (AnimalSoundCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AnimalSoundCollection clone = new AnimalSoundCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AnimalSound)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}