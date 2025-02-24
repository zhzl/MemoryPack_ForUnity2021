
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

namespace Models {

/// <remarks>
/// MemoryPack GenerateType: Object<br/>
/// <code>
/// <b>System.Collections.Generic.List&lt;int&gt;</b> List<br/>
/// </code>
/// </remarks>
partial class MyContainer2 : IMemoryPackable<MyContainer2>
{

    static partial void StaticConstructor();

    static MyContainer2()
    {
        RegisterFormatter();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    public static void RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<MyContainer2>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new MyContainer2Formatter());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<MyContainer2[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<MyContainer2>());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<global::System.Collections.Generic.List<int>>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ListFormatter<int>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    public static void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref MyContainer2? value) where TBufferWriter : class, System.Buffers.IBufferWriter<byte>
    {

        if (value == null)
        {
            writer.WriteNullObjectHeader();
            goto END;
        }

        writer.WriteObjectHeader(1);
        writer.WriteValue(value.@List);

    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    public static void Deserialize(ref MemoryPackReader reader, ref MyContainer2? value)
    {

        if (!reader.TryReadObjectHeader(out var count))
        {
            value = default!;
            goto END;
        }



        global::System.Collections.Generic.List<int> __List;

        
        if (count == 1)
        {
            if (value == null)
            {
                __List = reader.ReadValue<global::System.Collections.Generic.List<int>>();


                goto NEW;
            }
            else
            {
                __List = value.@List;

                reader.ReadValue(ref __List);

                goto SET;
            }

        }
        else if (count > 1)
        {
            MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(MyContainer2), 1, count);
            goto READ_END;
        }
        else
        {
            if (value == null)
            {
               __List = default!;
            }
            else
            {
               __List = value.@List;
            }


            if (count == 0) goto SKIP_READ;
            reader.ReadValue(ref __List); if (count == 1) goto SKIP_READ;

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
        
        value.@List = __List;
        goto READ_END;

    NEW:
        value = new MyContainer2()
        {
            @List = __List
        };

    READ_END:

    END:

        return;
    }
}
partial class MyContainer2
{
    [global::MemoryPack.Internal.Preserve]
    sealed class MyContainer2Formatter : MemoryPackFormatter<MyContainer2>
    {
        [global::MemoryPack.Internal.Preserve]
        public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer,  ref MyContainer2 value)
        {
            MyContainer2.Serialize(ref writer, ref value);
        }

        [global::MemoryPack.Internal.Preserve]
        public override void Deserialize(ref MemoryPackReader reader, ref MyContainer2 value)
        {
            MyContainer2.Deserialize(ref reader, ref value);
        }
    }
}
}
