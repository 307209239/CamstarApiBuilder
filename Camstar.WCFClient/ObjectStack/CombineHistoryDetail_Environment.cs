// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CombineHistoryDetail_Environment
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
  public class CombineHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_Qty2")]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050044, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_ContainerClosed")]
    protected Environment _ContainerClosed;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049409, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_CombineAllQty")]
    protected Environment _CombineAllQty;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049402, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_CloseWhenEmpty")]
    protected Environment _CloseWhenEmpty;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049397, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_FromContainer")]
    protected Environment _FromContainer;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1048769, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_ChildContainers")]
    protected Environment _ChildContainers;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Environment_Qty")]
    protected Environment _Qty;

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

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
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

    public Environment ContainerClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerClosed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerClosed));
      }
    }

    public Environment CombineAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CombineAllQty));
      }
    }

    public Environment CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Environment FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromContainer));
      }
    }

    public Environment ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
