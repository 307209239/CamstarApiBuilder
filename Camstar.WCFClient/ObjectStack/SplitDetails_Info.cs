// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SplitDetails_Info
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
  public class SplitDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Info_AttributeChanges")]
    protected Info _AttributeChanges;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Info_ToContainerName")]
    protected Info _ToContainerName;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Info_ToContainer")]
    protected Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Info_ChildContainers")]
    protected Info _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Info_AdjustThruput")]
    protected Info _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Info_Qty")]
    protected Info _Qty;

    public Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public Info AttributeChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeChanges), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeChanges));
      }
    }

    public Info ToContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainerName));
      }
    }

    public Info ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainer));
      }
    }

    public Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Info AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
