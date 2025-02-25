
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
/// MemoryPack GenerateType: VersionTolerant<br/>
/// <code>
/// <b>int</b> MyProperty1<br/>
/// <b>long</b> MyProperty2<br/>
/// </code>
/// </remarks>
partial class VersionTolerant2 : IMemoryPackable<VersionTolerant2>
{

    static partial void StaticConstructor();

    static VersionTolerant2()
    {
        RegisterFormatter();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    public static void RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<VersionTolerant2>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new VersionTolerant2Formatter());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<VersionTolerant2[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<VersionTolerant2>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    public static void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref VersionTolerant2? value) where TBufferWriter : class, System.Buffers.IBufferWriter<byte>
    {

        if (value == null)
        {
            writer.WriteNullObjectHeader();
            goto END;
        }

        writer.WriteObjectHeader(2);
        writer.WriteVarInt(System.Runtime.CompilerServices.Unsafe.SizeOf<int>());
        writer.WriteVarInt(System.Runtime.CompilerServices.Unsafe.SizeOf<long>());

        
        writer.WriteUnmanaged(value.@MyProperty1, value.@MyProperty2);

    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    public static void Deserialize(ref MemoryPackReader reader, ref VersionTolerant2? value)
    {

        if (!reader.TryReadObjectHeader(out var count))
        {
            value = default!;
            goto END;
        }

        Span<int> deltas = stackalloc int[count];
        for (int i = 0; i < count; i++)
        {
            deltas[i] = reader.ReadVarIntInt32();
        }

        int __MyProperty1;
        long __MyProperty2;

        var readCount = 2;
        if (count == 2)
        {
            if (value == null)
            {
                if (deltas[0] == 0) { __MyProperty1 = default; } else reader.ReadUnmanaged(out __MyProperty1);
                if (deltas[1] == 0) { __MyProperty2 = default; } else reader.ReadUnmanaged(out __MyProperty2);


                goto NEW;
            }
            else
            {
                __MyProperty1 = value.@MyProperty1;
                __MyProperty2 = value.@MyProperty2;

                if (deltas[0] != 0) reader.ReadUnmanaged(out __MyProperty1);
                if (deltas[1] != 0) reader.ReadUnmanaged(out __MyProperty2);

                goto SET;
            }

        }
        // else if (count > 2)
        // {
            // MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(VersionTolerant2), 2, count);
            // goto READ_END;
        // }
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
            if (deltas[0] != 0) reader.ReadUnmanaged(out __MyProperty1); if (count == 1) goto SKIP_READ;
            if (deltas[1] != 0) reader.ReadUnmanaged(out __MyProperty2); if (count == 2) goto SKIP_READ;

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
        value = new VersionTolerant2()
        {
            @MyProperty1 = __MyProperty1,
            @MyProperty2 = __MyProperty2
        };

    READ_END:
        if (count == readCount) goto END;

        for (int i = readCount; i < count; i++)
        {
            reader.Advance(deltas[i]);
        }
    END:

        return;
    }
}
partial class VersionTolerant2
{
    [global::MemoryPack.Internal.Preserve]
    sealed class VersionTolerant2Formatter : MemoryPackFormatter<VersionTolerant2>
    {
        [global::MemoryPack.Internal.Preserve]
        public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer,  ref VersionTolerant2 value)
        {
            VersionTolerant2.Serialize(ref writer, ref value);
        }

        [global::MemoryPack.Internal.Preserve]
        public override void Deserialize(ref MemoryPackReader reader, ref VersionTolerant2 value)
        {
            VersionTolerant2.Deserialize(ref reader, ref value);
        }
    }
}
}
