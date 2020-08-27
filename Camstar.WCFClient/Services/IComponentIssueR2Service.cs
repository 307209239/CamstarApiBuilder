// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IComponentIssueR2Service
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IComponentIssueR2Service
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_LoadESigDetails_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus SetMaterialListItemSettings(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ComponentIssueR2Method[] methods,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result);
  }
}
