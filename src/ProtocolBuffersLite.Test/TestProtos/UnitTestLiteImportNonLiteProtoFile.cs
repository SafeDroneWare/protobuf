// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=8fd7408b07f8d2cd.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos {
  
  public static partial class UnitTestLiteImportNonLiteProtoFile {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Extensions
    internal static readonly object Descriptor;
    static UnitTestLiteImportNonLiteProtoFile() {
      Descriptor = null;
    }
    #endregion
    
  }
  #region Messages
  public sealed partial class TestLiteImportsNonlite : pb::GeneratedMessageLite<TestLiteImportsNonlite, TestLiteImportsNonlite.Builder> {
    private static readonly TestLiteImportsNonlite defaultInstance = new Builder().BuildPartial();
    public static TestLiteImportsNonlite DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TestLiteImportsNonlite DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override TestLiteImportsNonlite ThisMessage {
      get { return this; }
    }
    
    public const int MessageFieldNumber = 1;
    private bool hasMessage;
    private global::Google.ProtocolBuffers.TestProtos.TestAllTypes message_ = global::Google.ProtocolBuffers.TestProtos.TestAllTypes.DefaultInstance;
    public bool HasMessage {
      get { return hasMessage; }
    }
    public global::Google.ProtocolBuffers.TestProtos.TestAllTypes Message {
      get { return message_; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasMessage) {
        output.WriteMessage(1, Message);
      }
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasMessage) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Message);
        }
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasMessage) hash ^= message_.GetHashCode();
      return hash;
    }
    
    public override bool Equals(object obj) {
      TestLiteImportsNonlite other = obj as TestLiteImportsNonlite;
      if (other == null) return false;
      if (hasMessage != other.hasMessage || (hasMessage && !message_.Equals(other.message_))) return false;
      return true;
    }
    
    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("message", hasMessage, message_, writer);
    }
    #endregion
    
    public static TestLiteImportsNonlite ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestLiteImportsNonlite prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilderLite<TestLiteImportsNonlite, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      TestLiteImportsNonlite result = new TestLiteImportsNonlite();
      
      protected override TestLiteImportsNonlite MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new TestLiteImportsNonlite();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override TestLiteImportsNonlite DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.TestProtos.TestLiteImportsNonlite.DefaultInstance; }
      }
      
      public override TestLiteImportsNonlite BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        TestLiteImportsNonlite returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is TestLiteImportsNonlite) {
          return MergeFrom((TestLiteImportsNonlite) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(TestLiteImportsNonlite other) {
        if (other == global::Google.ProtocolBuffers.TestProtos.TestLiteImportsNonlite.DefaultInstance) return this;
        if (other.HasMessage) {
          MergeMessage(other.Message);
        }
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag);
              break;
            }
            case 10: {
              global::Google.ProtocolBuffers.TestProtos.TestAllTypes.Builder subBuilder = global::Google.ProtocolBuffers.TestProtos.TestAllTypes.CreateBuilder();
              if (HasMessage) {
                subBuilder.MergeFrom(Message);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Message = subBuilder.BuildPartial();
              break;
            }
          }
        }
      }
      
      
      public bool HasMessage {
       get { return result.HasMessage; }
      }
      public global::Google.ProtocolBuffers.TestProtos.TestAllTypes Message {
        get { return result.Message; }
        set { SetMessage(value); }
      }
      public Builder SetMessage(global::Google.ProtocolBuffers.TestProtos.TestAllTypes value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasMessage = true;
        result.message_ = value;
        return this;
      }
      public Builder SetMessage(global::Google.ProtocolBuffers.TestProtos.TestAllTypes.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasMessage = true;
        result.message_ = builderForValue.Build();
        return this;
      }
      public Builder MergeMessage(global::Google.ProtocolBuffers.TestProtos.TestAllTypes value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.HasMessage &&
            result.message_ != global::Google.ProtocolBuffers.TestProtos.TestAllTypes.DefaultInstance) {
            result.message_ = global::Google.ProtocolBuffers.TestProtos.TestAllTypes.CreateBuilder(result.message_).MergeFrom(value).BuildPartial();
        } else {
          result.message_ = value;
        }
        result.hasMessage = true;
        return this;
      }
      public Builder ClearMessage() {
        result.hasMessage = false;
        result.message_ = global::Google.ProtocolBuffers.TestProtos.TestAllTypes.DefaultInstance;
        return this;
      }
    }
    static TestLiteImportsNonlite() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.UnitTestLiteImportNonLiteProtoFile.Descriptor, null);
    }
  }
  
  #endregion
  
}
