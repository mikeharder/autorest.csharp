// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtCustomizations.Models
{
    /// <summary> A dog. </summary>
    public partial class Dog : Pet
    {
        /// <summary> Initializes a new instance of Dog. </summary>
        public Dog()
        {
            Kind = PetKind.Dog;
        }

        /// <summary> Initializes a new instance of Dog. </summary>
        /// <param name="kind"> The kind of the pet. </param>
        /// <param name="name"> The name of the pet. </param>
        /// <param name="bark"> A dog can bark. </param>
        internal Dog(PetKind kind, string name, string bark) : base(kind, name)
        {
            Bark = bark;
            Kind = kind;
        }

        /// <summary> A dog can bark. </summary>
        public string Bark { get; set; }
    }
}
