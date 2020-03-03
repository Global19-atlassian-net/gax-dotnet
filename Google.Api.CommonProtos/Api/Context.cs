/*
 * Copyright 2020 Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/context.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/context.proto</summary>
  public static partial class ContextReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/context.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chhnb29nbGUvYXBpL2NvbnRleHQucHJvdG8SCmdvb2dsZS5hcGkiMQoHQ29u",
            "dGV4dBImCgVydWxlcxgBIAMoCzIXLmdvb2dsZS5hcGkuQ29udGV4dFJ1bGUi",
            "jQEKC0NvbnRleHRSdWxlEhAKCHNlbGVjdG9yGAEgASgJEhEKCXJlcXVlc3Rl",
            "ZBgCIAMoCRIQCghwcm92aWRlZBgDIAMoCRIiChphbGxvd2VkX3JlcXVlc3Rf",
            "ZXh0ZW5zaW9ucxgEIAMoCRIjChthbGxvd2VkX3Jlc3BvbnNlX2V4dGVuc2lv",
            "bnMYBSADKAlCbgoOY29tLmdvb2dsZS5hcGlCDENvbnRleHRQcm90b1ABWkVn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2FwaS9zZXJ2",
            "aWNlY29uZmlnO3NlcnZpY2Vjb25maWeiAgRHQVBJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Context), global::Google.Api.Context.Parser, new[]{ "Rules" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.ContextRule), global::Google.Api.ContextRule.Parser, new[]{ "Selector", "Requested", "Provided", "AllowedRequestExtensions", "AllowedResponseExtensions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// `Context` defines which contexts an API requests.
  ///
  /// Example:
  ///
  ///     context:
  ///       rules:
  ///       - selector: "*"
  ///         requested:
  ///         - google.rpc.context.ProjectContext
  ///         - google.rpc.context.OriginContext
  ///
  /// The above specifies that all methods in the API request
  /// `google.rpc.context.ProjectContext` and
  /// `google.rpc.context.OriginContext`.
  ///
  /// Available context types are defined in package
  /// `google.rpc.context`.
  ///
  /// This also provides mechanism to whitelist any protobuf message extension that
  /// can be sent in grpc metadata using “x-goog-ext-&lt;extension_id>-bin” and
  /// “x-goog-ext-&lt;extension_id>-jspb” format. For example, list any service
  /// specific protobuf types that can appear in grpc metadata as follows in your
  /// yaml file:
  ///
  /// Example:
  ///
  ///     context:
  ///       rules:
  ///        - selector: "google.example.library.v1.LibraryService.CreateBook"
  ///          allowed_request_extensions:
  ///          - google.foo.v1.NewExtension
  ///          allowed_response_extensions:
  ///          - google.foo.v1.NewExtension
  ///
  /// You can also specify extension ID instead of fully qualified extension name
  /// here.
  /// </summary>
  public sealed partial class Context : pb::IMessage<Context> {
    private static readonly pb::MessageParser<Context> _parser = new pb::MessageParser<Context>(() => new Context());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Context> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ContextReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Context() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Context(Context other) : this() {
      rules_ = other.rules_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Context Clone() {
      return new Context(this);
    }

    /// <summary>Field number for the "rules" field.</summary>
    public const int RulesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Api.ContextRule> _repeated_rules_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Api.ContextRule.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.ContextRule> rules_ = new pbc::RepeatedField<global::Google.Api.ContextRule>();
    /// <summary>
    /// A list of RPC context rules that apply to individual API methods.
    ///
    /// **NOTE:** All service configuration rules follow "last one wins" order.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Api.ContextRule> Rules {
      get { return rules_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Context);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Context other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rules_.Equals(other.rules_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rules_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      rules_.WriteTo(output, _repeated_rules_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += rules_.CalculateSize(_repeated_rules_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Context other) {
      if (other == null) {
        return;
      }
      rules_.Add(other.rules_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            rules_.AddEntriesFrom(input, _repeated_rules_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A context rule provides information about the context for an individual API
  /// element.
  /// </summary>
  public sealed partial class ContextRule : pb::IMessage<ContextRule> {
    private static readonly pb::MessageParser<ContextRule> _parser = new pb::MessageParser<ContextRule>(() => new ContextRule());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContextRule> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ContextReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContextRule() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContextRule(ContextRule other) : this() {
      selector_ = other.selector_;
      requested_ = other.requested_.Clone();
      provided_ = other.provided_.Clone();
      allowedRequestExtensions_ = other.allowedRequestExtensions_.Clone();
      allowedResponseExtensions_ = other.allowedResponseExtensions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContextRule Clone() {
      return new ContextRule(this);
    }

    /// <summary>Field number for the "selector" field.</summary>
    public const int SelectorFieldNumber = 1;
    private string selector_ = "";
    /// <summary>
    /// Selects the methods to which this rule applies.
    ///
    /// Refer to [selector][google.api.DocumentationRule.selector] for syntax details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Selector {
      get { return selector_; }
      set {
        selector_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "requested" field.</summary>
    public const int RequestedFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_requested_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> requested_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of full type names of requested contexts.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Requested {
      get { return requested_; }
    }

    /// <summary>Field number for the "provided" field.</summary>
    public const int ProvidedFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_provided_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> provided_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of full type names of provided contexts.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Provided {
      get { return provided_; }
    }

    /// <summary>Field number for the "allowed_request_extensions" field.</summary>
    public const int AllowedRequestExtensionsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_allowedRequestExtensions_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> allowedRequestExtensions_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of full type names or extension IDs of extensions allowed in grpc
    /// side channel from client to backend.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AllowedRequestExtensions {
      get { return allowedRequestExtensions_; }
    }

    /// <summary>Field number for the "allowed_response_extensions" field.</summary>
    public const int AllowedResponseExtensionsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_allowedResponseExtensions_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> allowedResponseExtensions_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of full type names or extension IDs of extensions allowed in grpc
    /// side channel from backend to client.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AllowedResponseExtensions {
      get { return allowedResponseExtensions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContextRule);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContextRule other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Selector != other.Selector) return false;
      if(!requested_.Equals(other.requested_)) return false;
      if(!provided_.Equals(other.provided_)) return false;
      if(!allowedRequestExtensions_.Equals(other.allowedRequestExtensions_)) return false;
      if(!allowedResponseExtensions_.Equals(other.allowedResponseExtensions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Selector.Length != 0) hash ^= Selector.GetHashCode();
      hash ^= requested_.GetHashCode();
      hash ^= provided_.GetHashCode();
      hash ^= allowedRequestExtensions_.GetHashCode();
      hash ^= allowedResponseExtensions_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Selector.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Selector);
      }
      requested_.WriteTo(output, _repeated_requested_codec);
      provided_.WriteTo(output, _repeated_provided_codec);
      allowedRequestExtensions_.WriteTo(output, _repeated_allowedRequestExtensions_codec);
      allowedResponseExtensions_.WriteTo(output, _repeated_allowedResponseExtensions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Selector.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Selector);
      }
      size += requested_.CalculateSize(_repeated_requested_codec);
      size += provided_.CalculateSize(_repeated_provided_codec);
      size += allowedRequestExtensions_.CalculateSize(_repeated_allowedRequestExtensions_codec);
      size += allowedResponseExtensions_.CalculateSize(_repeated_allowedResponseExtensions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContextRule other) {
      if (other == null) {
        return;
      }
      if (other.Selector.Length != 0) {
        Selector = other.Selector;
      }
      requested_.Add(other.requested_);
      provided_.Add(other.provided_);
      allowedRequestExtensions_.Add(other.allowedRequestExtensions_);
      allowedResponseExtensions_.Add(other.allowedResponseExtensions_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Selector = input.ReadString();
            break;
          }
          case 18: {
            requested_.AddEntriesFrom(input, _repeated_requested_codec);
            break;
          }
          case 26: {
            provided_.AddEntriesFrom(input, _repeated_provided_codec);
            break;
          }
          case 34: {
            allowedRequestExtensions_.AddEntriesFrom(input, _repeated_allowedRequestExtensions_codec);
            break;
          }
          case 42: {
            allowedResponseExtensions_.AddEntriesFrom(input, _repeated_allowedResponseExtensions_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
