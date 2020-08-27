// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VendorChanges_Info
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
  public class VendorChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Info_VendorItemItem")]
    protected VendorItemChanges_Info _VendorItemItem;
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Info_VendorItems")]
    protected VendorItemChanges_Info _VendorItems;
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Info_Name")]
    protected new Info _Name;

    public VendorItemChanges_Info VendorItemItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItemItem), (object) value);
      }
      get
      {
        return (VendorItemChanges_Info) this.PropertyGet(nameof (VendorItemItem));
      }
    }

    public VendorItemChanges_Info VendorItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItems), (object) value);
      }
      get
      {
        return (VendorItemChanges_Info) this.PropertyGet(nameof (VendorItems));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
