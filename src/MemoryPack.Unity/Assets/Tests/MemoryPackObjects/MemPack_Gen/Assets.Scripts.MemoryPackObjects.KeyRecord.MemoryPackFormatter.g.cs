
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

namespace Assets.Scripts.MemoryPackObjects {

/// <remarks>
/// MemoryPack GenerateType: unmanaged<br/>
/// <code>
/// <b>Assets.Scripts.MemoryPackObjects.EAction</b> action<br/>
/// <b>Assets.Scripts.MemoryPackObjects.EActionStatus</b> status<br/>
/// </code>
/// </remarks>
partial struct KeyRecord : IMemoryPackable<KeyRecord>
{

    static partial void StaticConstructor();

    static KeyRecord()
    {
        RegisterFormatter();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    public static void RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<KeyRecord>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new KeyRecordFormatter());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<KeyRecord[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<KeyRecord>());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<global::Assets.Scripts.MemoryPackObjects.EAction>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.UnmanagedFormatter<global::Assets.Scripts.MemoryPackObjects.EAction>());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<global::Assets.Scripts.MemoryPackObjects.EActionStatus>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.UnmanagedFormatter<global::Assets.Scripts.MemoryPackObjects.EActionStatus>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    public static void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref KeyRecord value) where TBufferWriter : class, System.Buffers.IBufferWriter<byte>
    {

        writer.WriteUnmanaged(value);
    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    public static void Deserialize(ref MemoryPackReader reader, ref KeyRecord value)
    {

        reader.ReadUnmanaged(out value);
    END:

        return;
    }
}
partial struct KeyRecord
{
    [global::MemoryPack.Internal.Preserve]
    sealed class KeyRecordFormatter : MemoryPackFormatter<KeyRecord>
    {
        [global::MemoryPack.Internal.Preserve]
        public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer,  ref KeyRecord value)
        {
            KeyRecord.Serialize(ref writer, ref value);
        }

        [global::MemoryPack.Internal.Preserve]
        public override void Deserialize(ref MemoryPackReader reader, ref KeyRecord value)
        {
            KeyRecord.Deserialize(ref reader, ref value);
        }
    }
}
}
