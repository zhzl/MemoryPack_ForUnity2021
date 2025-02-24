
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
/// <b>int</b> PublicProp<br/>
/// <b>int</b> PublicField<br/>
/// <b>string</b> PrivateSet<br/>
/// <b>string</b> PrivateGet<br/>
/// </code>
/// </remarks>
partial class NoInclude : IMemoryPackable<NoInclude>
{

    static partial void StaticConstructor();

    static NoInclude()
    {
        RegisterFormatter();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    public static void RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<NoInclude>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new NoIncludeFormatter());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<NoInclude[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<NoInclude>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    public static void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref NoInclude? value) where TBufferWriter : class, System.Buffers.IBufferWriter<byte>
    {

        if (value == null)
        {
            writer.WriteNullObjectHeader();
            goto END;
        }

        writer.WriteUnmanagedWithObjectHeader(4, value.@PublicProp, value.@PublicField);
        writer.WriteString(value.@PrivateSet);
        writer.WriteString(value.@PrivateGet);

    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    public static void Deserialize(ref MemoryPackReader reader, ref NoInclude? value)
    {

        if (!reader.TryReadObjectHeader(out var count))
        {
            value = default!;
            goto END;
        }



        int __PublicProp;
        int __PublicField;
        string __PrivateSet;
        string __PrivateGet;

        
        if (count == 4)
        {
            if (value == null)
            {
                reader.ReadUnmanaged(out __PublicProp, out __PublicField);
                __PrivateSet = reader.ReadString();
                __PrivateGet = reader.ReadString();


                goto NEW;
            }
            else
            {
                __PublicProp = value.@PublicProp;
                __PublicField = value.@PublicField;
                __PrivateSet = value.@PrivateSet;
                __PrivateGet = value.@PrivateGet;

                reader.ReadUnmanaged(out __PublicProp);
                reader.ReadUnmanaged(out __PublicField);
                __PrivateSet = reader.ReadString();
                __PrivateGet = reader.ReadString();

                goto SET;
            }

        }
        else if (count > 4)
        {
            MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(NoInclude), 4, count);
            goto READ_END;
        }
        else
        {
            if (value == null)
            {
               __PublicProp = default!;
               __PublicField = default!;
               __PrivateSet = default!;
               __PrivateGet = default!;
            }
            else
            {
               __PublicProp = value.@PublicProp;
               __PublicField = value.@PublicField;
               __PrivateSet = value.@PrivateSet;
               __PrivateGet = value.@PrivateGet;
            }


            if (count == 0) goto SKIP_READ;
            reader.ReadUnmanaged(out __PublicProp); if (count == 1) goto SKIP_READ;
            reader.ReadUnmanaged(out __PublicField); if (count == 2) goto SKIP_READ;
            __PrivateSet = reader.ReadString(); if (count == 3) goto SKIP_READ;
            __PrivateGet = reader.ReadString(); if (count == 4) goto SKIP_READ;

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
        
        value.@PublicProp = __PublicProp;
        value.@PublicField = __PublicField;
        value.@PrivateSet = __PrivateSet;
        value.@PrivateGet = __PrivateGet;
        goto READ_END;

    NEW:
        value = new NoInclude()
        {
            @PublicProp = __PublicProp,
            @PublicField = __PublicField,
            @PrivateSet = __PrivateSet,
            @PrivateGet = __PrivateGet
        };

    READ_END:

    END:

        return;
    }
}
partial class NoInclude
{
    [global::MemoryPack.Internal.Preserve]
    sealed class NoIncludeFormatter : MemoryPackFormatter<NoInclude>
    {
        [global::MemoryPack.Internal.Preserve]
        public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer,  ref NoInclude value)
        {
            NoInclude.Serialize(ref writer, ref value);
        }

        [global::MemoryPack.Internal.Preserve]
        public override void Deserialize(ref MemoryPackReader reader, ref NoInclude value)
        {
            NoInclude.Deserialize(ref reader, ref value);
        }
    }
}
}
