// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalTabChanges_Environment
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
  public class PortalTabChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalTabChanges_Environment_IconUrl")]
    [Metadata("URL", "", true, false, false, "String", 1052706, false, false, false, null)]
    protected Environment _IconUrl;
    [DataMember(EmitDefaultValue = false, Name = "PortalTabChanges_Environment_ObjectToChange")]
    [Metadata("Tab defs for use in menus.", "PortalTab", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052705, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalTabChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment IconUrl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconUrl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconUrl));
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

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
