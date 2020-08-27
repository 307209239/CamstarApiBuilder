// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuCommandChanges_Environment
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
  public class MenuCommandChanges_Environment : MenuItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_Environment_ObjectToChange")]
    [Metadata("An instance of a MenuItemCommand is used to provide a command to be performed (in contrast to a sub-menu).", "MenuCommand", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("An instance of a MenuItemCommand is used to provide a command to be performed (in contrast to a sub-menu).", "MenuCommandChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_Environment_Sequence")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049605, false, false, false, null)]
    protected new Environment _Sequence;

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

    public new Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }
  }
}
