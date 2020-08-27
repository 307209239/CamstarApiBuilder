// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeAttributeHistory_Environment
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
  public class ChangeAttributeHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("ChangeAttributeHistoryDetails.\r\nThe ChangeAttributeHistoryDetails History CDO contains the information on how the details field was filled out for the ChangeAttribute transaction, and also contains information on the value of the field prior to the transaction.  Note this History CDO only contains information on the \"old\" value of the main container that is being updated--if this transaction is set to update child containers, the \"old\" values for the child containers are not stored in this History CDO.  There are multiple subtypes of this CDO--one for every basic type of field that exists in InSite.", "ChangeAttributeHistoryDetails", false, false, false, "ChangeAttributeHistoryDetails", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistory_Environment_HistoryDetails")]
    protected ChangeAttributeHistoryDetails_Environment _HistoryDetails;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistory_Environment_IncludeChildren")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049124, false, false, false, null)]
    protected Environment _IncludeChildren;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

    public ChangeAttributeHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ChangeAttributeHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public Environment IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeChildren));
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
