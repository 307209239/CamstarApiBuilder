// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserProfile
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UserProfile
  {
    [DataMember(EmitDefaultValue = false, Name = "SessionID")]
    public EncryptedField SessionID { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Name")]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Password")]
    public EncryptedField Password { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "UTCOffset")]
    public TimeSpan UTCOffset { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Dictionary")]
    public string Dictionary { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "ServerName")]
    public string ServerName { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "DebugRequest")]
    public DebugRequest DebugRequest { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "FilterTags")]
    public string FilterTags { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "FilterTagAccess")]
    public string FilterTagAccess { get; set; }

    public UserProfile()
    {
    }

    public UserProfile(string name, string password)
    {
      this.Name = name;
      this.Password = (EncryptedField) password;
    }

    public UserProfile(string name, string password, TimeSpan utcOffset, string dictionary)
    {
      this.Name = name;
      this.Password = (EncryptedField) password;
      this.UTCOffset = utcOffset;
      this.Dictionary = dictionary;
    }

    public UserProfile(
      string name,
      string password,
      TimeSpan utcOffset,
      string dictionary,
      string servername)
    {
      this.Name = name;
      this.Password = (EncryptedField) password;
      this.UTCOffset = utcOffset;
      this.Dictionary = dictionary;
      this.ServerName = servername;
    }

    public UserProfile(string name, EncryptedField password)
    {
      this.Name = name;
      this.Password = password;
    }

    public UserProfile(string name, string password, string servername)
    {
      this.Name = name;
      this.Password = (EncryptedField) password;
      this.ServerName = servername;
    }

    public UserProfile(string name, string password, TimeSpan utcOffset)
    {
      this.Name = name;
      this.Password = (EncryptedField) password;
      this.UTCOffset = utcOffset;
    }

    public static UserProfile CreateEncryptedUserProfile(string name, string password)
    {
      return new UserProfile(name, EncryptedField.CreateEncryptedField(password));
    }
  }
}
