// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DefectHistoryDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerDefectHistoryDetail_Environment))]
  [KnownType(typeof (ComponentDefectHistoryDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DefectHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_Environment_DefectCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048790, false, false, false, null)]
    protected Environment _DefectCount;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_Environment_Comment")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1049480, false, false, false, null)]
    protected Environment _Comment;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_Environment_ReasonCode")]
    [Metadata("User codes are most often used to define loss reasons through selection lists for data entry fields. InSite provides several user codes such as Bonus Reason and Loss Reason. User Defined Codes are used to allow each customer to specify a list of allowable values for a specific field. In many cases a User Defined Code will merely consist of a Name and Description with no additional attributes. They may also include additional attributes, typically used for additional validations.\r\n\r\nThe name for each Code must be unique within its type. This value is used as an alternate key for lookup-up, data entry and validation.\r\n", "UserCode", false, false, false, "NamedObjectRef", 1049479, false, false, false, null)]
    protected Environment _ReasonCode;

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

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
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

    public Environment DefectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefectCount));
      }
    }

    public Environment Comment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comment));
      }
    }

    public Environment ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReasonCode));
      }
    }
  }
}
