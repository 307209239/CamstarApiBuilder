// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UILinkActionChanges_Info
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
  public class UILinkActionChanges_Info : UIActionChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Info_URL")]
    protected Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Info_QueryStringParameters")]
    protected QueryStringParameterChanges_Info _QueryStringParameters;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Info_Name")]
    protected new Info _Name;

    public Info URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (URL));
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

    public QueryStringParameterChanges_Info QueryStringParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryStringParameters), (object) value);
      }
      get
      {
        return (QueryStringParameterChanges_Info) this.PropertyGet(nameof (QueryStringParameters));
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
