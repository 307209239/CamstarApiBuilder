// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLocationChanges_Info
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
  public class UIFloatPageLocationChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Info_Height")]
    protected Info _Height;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Info_Width")]
    protected Info _Width;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info Height
    {
      [param: In] set
      {
        this.PropertySet(nameof (Height), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Height));
      }
    }

    public Info Width
    {
      [param: In] set
      {
        this.PropertySet(nameof (Width), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Width));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
