
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
/// <b>int</b> MyProperty<br/>
/// <b>long</b> Foo<br/>
/// </code>
/// </remarks>
partial class ImplA1 : IMemoryPackable<ImplA1>
{

    static partial void StaticConstructor();

    static ImplA1()
    {
        RegisterFormatter();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    public static void RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<ImplA1>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new ImplA1Formatter());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<ImplA1[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<ImplA1>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    public static void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref ImplA1? value) where TBufferWriter : class, System.Buffers.IBufferWriter<byte>
    {

        if (value == null)
        {
            writer.WriteNullObjectHeader();
            goto END;
        }

        writer.WriteUnmanagedWithObjectHeader(2, value.@MyProperty, value.@Foo);

    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    public static void Deserialize(ref MemoryPackReader reader, ref ImplA1? value)
    {

        if (!reader.TryReadObjectHeader(out var count))
        {
            value = default!;
            goto END;
        }



        int __MyProperty;
        long __Foo;

        
        if (count == 2)
        {
            if (value == null)
            {
                reader.ReadUnmanaged(out __MyProperty, out __Foo);


                goto NEW;
            }
            else
            {
                __MyProperty = value.@MyProperty;
                __Foo = value.@Foo;

                reader.ReadUnmanaged(out __MyProperty);
                reader.ReadUnmanaged(out __Foo);

                goto SET;
            }

        }
        else if (count > 2)
        {
            MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(ImplA1), 2, count);
            goto READ_END;
        }
        else
        {
            if (value == null)
            {
               __MyProperty = default!;
               __Foo = default!;
            }
            else
            {
               __MyProperty = value.@MyProperty;
               __Foo = value.@Foo;
            }


            if (count == 0) goto SKIP_READ;
            reader.ReadUnmanaged(out __MyProperty); if (count == 1) goto SKIP_READ;
            reader.ReadUnmanaged(out __Foo); if (count == 2) goto SKIP_READ;

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
        
        value.@MyProperty = __MyProperty;
        value.@Foo = __Foo;
        goto READ_END;

    NEW:
        value = new ImplA1()
        {
            @MyProperty = __MyProperty,
            @Foo = __Foo
        };

    READ_END:

    END:

        return;
    }
}
partial class ImplA1
{
    [global::MemoryPack.Internal.Preserve]
    sealed class ImplA1Formatter : MemoryPackFormatter<ImplA1>
    {
        [global::MemoryPack.Internal.Preserve]
        public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer,  ref ImplA1 value)
        {
            ImplA1.Serialize(ref writer, ref value);
        }

        [global::MemoryPack.Internal.Preserve]
        public override void Deserialize(ref MemoryPackReader reader, ref ImplA1 value)
        {
            ImplA1.Deserialize(ref reader, ref value);
        }
    }
}
}
