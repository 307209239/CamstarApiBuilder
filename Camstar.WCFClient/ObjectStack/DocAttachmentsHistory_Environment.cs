// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DocAttachmentsHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Environment_ParentDisplayName")]
    [Metadata("DisplayName", "", false, false, true, "String", 1051140, false, false, false, null)]
    protected Environment _ParentDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Environment_ObjectType")]
    [Metadata("CDOType", "", false, false, true, "Integer", 1050572, false, false, false, null)]
    protected Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Environment_HistoryDetails")]
    [Metadata("Document Attachments History Details", "DocAttachmentsHistoryDetails", false, false, false, "DocAttachmentsHistoryDetails", 1049096, false, true, false, null)]
    protected DocAttachmentsHistoryDetails_Environment _HistoryDetails;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Environment_AttachmentsOwner")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1051143, false, false, false, null)]
    protected Environment _AttachmentsOwner;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Environment_ObjectRev")]
    [Metadata("Generic String", "", false, false, true, "String", 1051139, false, false, false, null)]
    protected Environment _ObjectRev;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050774, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Environment_ObjectName")]
    protected Environment _ObjectName;

    public Environment ParentDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDisplayName));
      }
    }

    public Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public DocAttachmentsHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DocAttachmentsHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment AttachmentsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentsOwner));
      }
    }

    public Environment ObjectRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectRev));
      }
    }

    public Environment ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectName));
      }
    }
  }
}
