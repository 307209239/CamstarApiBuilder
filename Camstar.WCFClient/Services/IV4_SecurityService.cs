// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IV4_SecurityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IV4_SecurityService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      V4_Security v4_Security,
      V4_Security_Parameters parameters,
      V4_Security_Request request,
      out V4_Security_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      V4_Security v4_Security,
      V4_Security_Parameters parameters,
      V4_Security_Request request,
      out V4_Security_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      V4_SecurityMethod[] methods,
      V4_Security_Request request,
      out V4_Security_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      V4_Security v4_Security,
      V4_Security_Request request,
      out V4_Security_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      V4_Security v4_Security,
      V4_Security_Request request,
      out V4_Security_Result result);
  }
}
