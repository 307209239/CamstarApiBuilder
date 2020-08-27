// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Update update,
      Update_Parameters parameters,
      Update_Request request,
      out Update_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Update update,
      Update_Parameters parameters,
      Update_Request request,
      out Update_Result result);

    [OperationContract]
    ResultStatus WriteTxnGUID(
      UserProfile userProfile,
      Update update,
      Update_Parameters parameters,
      Update_Request request,
      out Update_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateMethod[] methods,
      Update_Request request,
      out Update_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Update update,
      Update_Request request,
      out Update_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Update update,
      Update_Request request,
      out Update_Result result);
  }
}
