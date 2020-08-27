// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLocationChanges_Environment
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
  public class UIFloatPageLocationChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("UI Float Page Location", "UIFloatPageLocationChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Environment_ObjectToChange")]
    [Metadata("UI Float Page Location", "UIFloatPageLocation", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052808, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Environment_Height")]
    protected Environment _Height;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Environment_Width")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052807, false, false, false, null)]
    protected Environment _Width;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocationChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment Height
    {
      [param: In] set
      {
        this.PropertySet(nameof (Height), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Height));
      }
    }

    public Environment Width
    {
      [param: In] set
      {
        this.PropertySet(nameof (Width), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Width));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
