
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
/// <b>int</b> MyProperty1<br/>
/// <b>int</b> MyProperty2<br/>
/// </code>
/// </remarks>
partial class Versioning2 : IMemoryPackable<Versioning2>
{

    static partial void StaticConstructor();

    static Versioning2()
    {
        RegisterFormatter();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    public static void RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<Versioning2>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new Versioning2Formatter());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<Versioning2[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<Versioning2>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    public static void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref Versioning2? value) where TBufferWriter : class, System.Buffers.IBufferWriter<byte>
    {

        if (value == null)
        {
            writer.WriteNullObjectHeader();
            goto END;
        }

        writer.WriteUnmanagedWithObjectHeader(2, value.@MyProperty1, value.@MyProperty2);

    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    public static void Deserialize(ref MemoryPackReader reader, ref Versioning2? value)
    {

        if (!reader.TryReadObjectHeader(out var count))
        {
            value = default!;
            goto END;
        }



        int __MyProperty1;
        int __MyProperty2;

        
        if (count == 2)
        {
            if (value == null)
            {
                reader.ReadUnmanaged(out __MyProperty1, out __MyProperty2);


                goto NEW;
            }
            else
            {
                __MyProperty1 = value.@MyProperty1;
                __MyProperty2 = value.@MyProperty2;

                reader.ReadUnmanaged(out __MyProperty1);
                reader.ReadUnmanaged(out __MyProperty2);

                goto SET;
            }

        }
        else if (count > 2)
        {
            MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(Versioning2), 2, count);
            goto READ_END;
        }
        else
        {
            if (value == null)
            {
               __MyProperty1 = default!;
               __MyProperty2 = default!;
            }
            else
            {
               __MyProperty1 = value.@MyProperty1;
               __MyProperty2 = value.@MyProperty2;
            }


            if (count == 0) goto SKIP_READ;
            reader.ReadUnmanaged(out __MyProperty1); if (count == 1) goto SKIP_READ;
            reader.ReadUnmanaged(out __MyProperty2); if (count == 2) goto SKIP_READ;

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
        
        value.@MyProperty1 = __MyProperty1;
        value.@MyProperty2 = __MyProperty2;
        goto READ_END;

    NEW:
        value = new Versioning2()
        {
            @MyProperty1 = __MyProperty1,
            @MyProperty2 = __MyProperty2
        };

    READ_END:

    END:

        return;
    }
}
partial class Versioning2
{
    [global::MemoryPack.Internal.Preserve]
    sealed class Versioning2Formatter : MemoryPackFormatter<Versioning2>
    {
        [global::MemoryPack.Internal.Preserve]
        public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer,  ref Versioning2 value)
        {
            Versioning2.Serialize(ref writer, ref value);
        }

        [global::MemoryPack.Internal.Preserve]
        public override void Deserialize(ref MemoryPackReader reader, ref Versioning2 value)
        {
            Versioning2.Deserialize(ref reader, ref value);
        }
    }
}
}
