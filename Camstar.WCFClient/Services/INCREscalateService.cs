// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCREscalateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCREscalateService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_LoadESigDetails_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCREscalateMethod[] methods,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result);
  }
}
