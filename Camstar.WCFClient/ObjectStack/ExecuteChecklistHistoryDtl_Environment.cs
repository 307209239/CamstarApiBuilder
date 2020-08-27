// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistHistoryDtl_Environment
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
  public class ExecuteChecklistHistoryDtl_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Environment_UserComments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Environment_ChecklistText")]
    [Metadata("Comments", "", false, false, true, "String", 1052422, false, false, false, null)]
    protected Environment _ChecklistText;
    [Metadata("Defines the response entry within Checklist Configuration.", "ChecklistEntry", false, false, true, "NamedSubentityRef", 1052421, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Environment_ChecklistEntry")]
    protected Environment _ChecklistEntry;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Environment_ResponseSet")]
    [Metadata("The Response Set is an object which allows the user to configure various response sets.", "ResponseSet", false, false, true, "NamedObjectRef", 1052374, false, false, false, null)]
    protected Environment _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Environment_UserResponses")]
    [Metadata("Response for an entry in the Checklist.", "ExecuteChklstResponseHistDtl", false, false, true, "ExecuteChklstResponseHistDtl", 1052419, false, true, false, null)]
    protected ExecuteChklstResponseHistDtl_Environment _UserResponses;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Environment_HistoryId")]
    protected new Environment _HistoryId;

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

    public Environment UserComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserComments));
      }
    }

    public Environment ChecklistText
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistText));
      }
    }

    public Environment ChecklistEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistEntry));
      }
    }

    public Environment ResponseSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseSet));
      }
    }

    public ExecuteChklstResponseHistDtl_Environment UserResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserResponses), (object) value);
      }
      get
      {
        return (ExecuteChklstResponseHistDtl_Environment) this.PropertyGet(nameof (UserResponses));
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
  }
}
