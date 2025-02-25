
// <auto-generated/>
#nullable enable
#pragma warning disable CS0108 // hides inherited member
#pragma warning disable CS0162 // Unreachable code
#pragma warning disable CS0164 // This label has not been referenced
#pragma warning disable CS0219 // Variable assigned but never used
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment
#pragma warning disable CS8602
#pragma warning disable CS8604 // Possible null reference argument for parameter
#pragma warning disable CS8619
#pragma warning disable CS8620
#pragma warning disable CS8631 // The type cannot be used as type parameter in the generic type or method
#pragma warning disable CS8765 // Nullability of type of parameter
#pragma warning disable CS9074 // The 'scoped' modifier of parameter doesn't match overridden or implemented member
#pragma warning disable CA1050 // Declare types in namespaces.

using System;
using MemoryPack;

namespace MemoryPack.Tests.Models {

/// <remarks>
/// MemoryPack GenerateType: Object<br/>
/// <code>
/// </code>
/// </remarks>
partial class Versioning0 : IMemoryPackable<Versioning0>
{

    static partial void StaticConstructor();

    static Versioning0()
    {
        RegisterFormatter();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    public static void RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<Versioning0>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new Versioning0Formatter());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<Versioning0[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<Versioning0>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    public static void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref Versioning0? value) where TBufferWriter : class, System.Buffers.IBufferWriter<byte>
    {

        if (value == null)
        {
            writer.WriteNullObjectHeader();
            goto END;
        }

        writer.WriteObjectHeader(0);
    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    public static void Deserialize(ref MemoryPackReader reader, ref Versioning0? value)
    {

        if (!reader.TryReadObjectHeader(out var count))
        {
            value = default!;
            goto END;
        }





        
        if (count == 0)
        {
            if (value == null)
            {


                goto NEW;
            }
            else
            {




                goto SET;
            }

        }
        else if (count > 0)
        {
            MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(Versioning0), 0, count);
            goto READ_END;
        }
        else
        {
            if (value == null)
            {

            }
            else
            {

            }


            if (count == 0) goto SKIP_READ;


    SKIP_READ:
            if (value == null)
            {
                goto NEW;
            }
            else
            {
                goto SET;
            }

        }

    SET:
        

        goto READ_END;

    NEW:
        value = new Versioning0()
        {

        };

    READ_END:

    END:

        return;
    }
}
partial class Versioning0
{
    [global::MemoryPack.Internal.Preserve]
    sealed class Versioning0Formatter : MemoryPackFormatter<Versioning0>
    {
        [global::MemoryPack.Internal.Preserve]
        public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer,  ref Versioning0 value)
        {
            Versioning0.Serialize(ref writer, ref value);
        }

        [global::MemoryPack.Internal.Preserve]
        public override void Deserialize(ref MemoryPackReader reader, ref Versioning0 value)
        {
            Versioning0.Deserialize(ref reader, ref value);
        }
    }
}
}
