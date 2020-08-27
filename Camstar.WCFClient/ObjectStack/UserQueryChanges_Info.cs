// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryChanges_Info
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
  public class UserQueryChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Info_UserQueryParameters")]
    protected UserQueryParameterChanges_Info _UserQueryParameters;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Info_QueryText")]
    protected Info _QueryText;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Info_Name")]
    protected new Info _Name;

    public UserQueryParameterChanges_Info UserQueryParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryParameters), (object) value);
      }
      get
      {
        return (UserQueryParameterChanges_Info) this.PropertyGet(nameof (UserQueryParameters));
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

    public Info QueryText
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryText));
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
