// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetNCRsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetNCRsService
  {
    [OperationContract]
    ResultStatus GetNonconformances(
      UserProfile userProfile,
      GetNCRs getNCRs,
      GetNCRs_Parameters parameters,
      GetNCRs_Request request,
      out GetNCRs_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GetNCRs getNCRs,
      GetNCRs_Parameters parameters,
      GetNCRs_Request request,
      out GetNCRs_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetNCRsMethod[] methods,
      GetNCRs_Request request,
      out GetNCRs_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GetNCRs getNCRs,
      GetNCRs_Request request,
      out GetNCRs_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GetNCRs getNCRs,
      GetNCRs_Request request,
      out GetNCRs_Result result);
  }
}
