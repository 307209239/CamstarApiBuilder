// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerTxnService : ShopFloorBase
  {
    public ContainerTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerTxnService), userProfile);
    }

    public ResultStatus AddAffectedContainerToEvent(
      ContainerTxn containerTxn,
      ContainerTxn_AddAffectedContainerToEvent_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (AddAffectedContainerToEvent), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).AddAffectedContainerToEvent(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.AddAffectedContainerToEvent, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddAffectedContainerToEvent), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddAffectedContainerToEvent()
    {
      return this.AddAffectedContainerToEvent((ContainerTxn) null, (ContainerTxn_AddAffectedContainerToEvent_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus AddAffectedContainerToEvent(ContainerTxn containerTxn)
    {
      return this.AddAffectedContainerToEvent(containerTxn, (ContainerTxn_AddAffectedContainerToEvent_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus AddAffectedContainerToEvent(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.AddAffectedContainerToEvent(containerTxn, (ContainerTxn_AddAffectedContainerToEvent_Parameters) null, request, out result);
    }

    public ResultStatus AddChildEventsToParentContainer(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (AddChildEventsToParentContainer), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).AddChildEventsToParentContainer(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.AddChildEventsToParentContainer, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddChildEventsToParentContainer), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddChildEventsToParentContainer()
    {
      return this.AddChildEventsToParentContainer((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus AddChildEventsToParentContainer(ContainerTxn containerTxn)
    {
      return this.AddChildEventsToParentContainer(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus AddChildEventsToParentContainer(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.AddChildEventsToParentContainer(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus AddParentEventsToChildContainers(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (AddParentEventsToChildContainers), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).AddParentEventsToChildContainers(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.AddParentEventsToChildContainers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddParentEventsToChildContainers), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddParentEventsToChildContainers()
    {
      return this.AddParentEventsToChildContainers((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus AddParentEventsToChildContainers(ContainerTxn containerTxn)
    {
      return this.AddParentEventsToChildContainers(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus AddParentEventsToChildContainers(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.AddParentEventsToChildContainers(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus AffectContainersToEvents(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (AffectContainersToEvents), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).AffectContainersToEvents(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.AffectContainersToEvents, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AffectContainersToEvents), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AffectContainersToEvents()
    {
      return this.AffectContainersToEvents((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus AffectContainersToEvents(ContainerTxn containerTxn)
    {
      return this.AffectContainersToEvents(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus AffectContainersToEvents(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.AffectContainersToEvents(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus CheckQtyIssued(
      ContainerTxn containerTxn,
      ContainerTxn_CheckQtyIssued_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (CheckQtyIssued), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).CheckQtyIssued(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.CheckQtyIssued, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckQtyIssued), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckQtyIssued()
    {
      return this.CheckQtyIssued((ContainerTxn) null, (ContainerTxn_CheckQtyIssued_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus CheckQtyIssued(ContainerTxn containerTxn)
    {
      return this.CheckQtyIssued(containerTxn, (ContainerTxn_CheckQtyIssued_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus CheckQtyIssued(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.CheckQtyIssued(containerTxn, (ContainerTxn_CheckQtyIssued_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).CreateParametricData(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus CreateParametricData(ContainerTxn containerTxn)
    {
      return this.CreateParametricData(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.CreateParametricData(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus CreatePTHistory(
      ContainerTxn containerTxn,
      ContainerTxn_CreatePTHistory_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (CreatePTHistory), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).CreatePTHistory(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.CreatePTHistory, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreatePTHistory), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreatePTHistory()
    {
      return this.CreatePTHistory((ContainerTxn) null, (ContainerTxn_CreatePTHistory_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus CreatePTHistory(ContainerTxn containerTxn)
    {
      return this.CreatePTHistory(containerTxn, (ContainerTxn_CreatePTHistory_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus CreatePTHistory(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.CreatePTHistory(containerTxn, (ContainerTxn_CreatePTHistory_Parameters) null, request, out result);
    }

    public ResultStatus EnforceMaterialConsumptionCheck(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (EnforceMaterialConsumptionCheck), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).EnforceMaterialConsumptionCheck(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.EnforceMaterialConsumptionCheck, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (EnforceMaterialConsumptionCheck), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus EnforceMaterialConsumptionCheck()
    {
      return this.EnforceMaterialConsumptionCheck((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus EnforceMaterialConsumptionCheck(ContainerTxn containerTxn)
    {
      return this.EnforceMaterialConsumptionCheck(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus EnforceMaterialConsumptionCheck(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.EnforceMaterialConsumptionCheck(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteProcessTimerDisposition(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteProcessTimerDisposition), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ExecuteProcessTimerDisposition(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ExecuteProcessTimerDisposition, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteProcessTimerDisposition), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteProcessTimerDisposition()
    {
      return this.ExecuteProcessTimerDisposition((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ExecuteProcessTimerDisposition(ContainerTxn containerTxn)
    {
      return this.ExecuteProcessTimerDisposition(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ExecuteProcessTimerDisposition(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ExecuteProcessTimerDisposition(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetActions(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetActions(ContainerTxn containerTxn)
    {
      return this.GetActions(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetActions(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetActions(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetAllIssueDetails(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetAllIssueDetails), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetAllIssueDetails(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetAllIssueDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAllIssueDetails), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAllIssueDetails()
    {
      return this.GetAllIssueDetails((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetAllIssueDetails(ContainerTxn containerTxn)
    {
      return this.GetAllIssueDetails(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetAllIssueDetails(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetAllIssueDetails(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetDataPoints(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetDataPoints(ContainerTxn containerTxn)
    {
      return this.GetDataPoints(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetDataPoints(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetIssueDetails(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetIssueDetails), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetIssueDetails(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetIssueDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetIssueDetails), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetIssueDetails()
    {
      return this.GetIssueDetails((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetIssueDetails(ContainerTxn containerTxn)
    {
      return this.GetIssueDetails(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetIssueDetails(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetIssueDetails(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetOwnerRole_ForPTProdEvent(
      ContainerTxn containerTxn,
      ContainerTxn_GetOwnerRole_ForPTProdEvent_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetOwnerRole_ForPTProdEvent), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetOwnerRole_ForPTProdEvent(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetOwnerRole_ForPTProdEvent, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetOwnerRole_ForPTProdEvent), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetOwnerRole_ForPTProdEvent()
    {
      return this.GetOwnerRole_ForPTProdEvent((ContainerTxn) null, (ContainerTxn_GetOwnerRole_ForPTProdEvent_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetOwnerRole_ForPTProdEvent(ContainerTxn containerTxn)
    {
      return this.GetOwnerRole_ForPTProdEvent(containerTxn, (ContainerTxn_GetOwnerRole_ForPTProdEvent_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetOwnerRole_ForPTProdEvent(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetOwnerRole_ForPTProdEvent(containerTxn, (ContainerTxn_GetOwnerRole_ForPTProdEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetProductFamilyTrainingRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetProductFamilyTrainingRequirements), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetProductFamilyTrainingRequirements(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetProductFamilyTrainingRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetProductFamilyTrainingRequirements), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetProductFamilyTrainingRequirements()
    {
      return this.GetProductFamilyTrainingRequirements((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetProductFamilyTrainingRequirements(ContainerTxn containerTxn)
    {
      return this.GetProductFamilyTrainingRequirements(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetProductFamilyTrainingRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetProductFamilyTrainingRequirements(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetProductTrainingRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetProductTrainingRequirements), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetProductTrainingRequirements(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetProductTrainingRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetProductTrainingRequirements), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetProductTrainingRequirements()
    {
      return this.GetProductTrainingRequirements((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetProductTrainingRequirements(ContainerTxn containerTxn)
    {
      return this.GetProductTrainingRequirements(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetProductTrainingRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetProductTrainingRequirements(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetResourceTrainingRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetResourceTrainingRequirements), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetResourceTrainingRequirements(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetResourceTrainingRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetResourceTrainingRequirements), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetResourceTrainingRequirements()
    {
      return this.GetResourceTrainingRequirements((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetResourceTrainingRequirements(ContainerTxn containerTxn)
    {
      return this.GetResourceTrainingRequirements(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetResourceTrainingRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetResourceTrainingRequirements(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetSpecTrainingRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetSpecTrainingRequirements), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetSpecTrainingRequirements(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetSpecTrainingRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetSpecTrainingRequirements), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetSpecTrainingRequirements()
    {
      return this.GetSpecTrainingRequirements((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetSpecTrainingRequirements(ContainerTxn containerTxn)
    {
      return this.GetSpecTrainingRequirements(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetSpecTrainingRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetSpecTrainingRequirements(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetStopTimersWithESig(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetStopTimersWithESig), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetStopTimersWithESig(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetStopTimersWithESig, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetStopTimersWithESig), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetStopTimersWithESig()
    {
      return this.GetStopTimersWithESig((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetStopTimersWithESig(ContainerTxn containerTxn)
    {
      return this.GetStopTimersWithESig(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetStopTimersWithESig(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetStopTimersWithESig(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).GetWIPMsgs(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerTxn containerTxn)
    {
      return this.GetWIPMsgs(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetWIPMsgs(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).Load(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus Load(ContainerTxn containerTxn)
    {
      return this.Load(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus Load(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.Load(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainerTxn containerTxn,
      ContainerTxn_LoadESigDetails_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).LoadESigDetails(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.LoadESigDetails, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainerTxn) null, (ContainerTxn_LoadESigDetails_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus LoadESigDetails(ContainerTxn containerTxn)
    {
      return this.LoadESigDetails(containerTxn, (ContainerTxn_LoadESigDetails_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.LoadESigDetails(containerTxn, (ContainerTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus MapLastActivityToContainer(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (MapLastActivityToContainer), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).MapLastActivityToContainer(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.MapLastActivityToContainer, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (MapLastActivityToContainer), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus MapLastActivityToContainer()
    {
      return this.MapLastActivityToContainer((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus MapLastActivityToContainer(ContainerTxn containerTxn)
    {
      return this.MapLastActivityToContainer(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus MapLastActivityToContainer(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.MapLastActivityToContainer(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus MapLastMoveDate(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (MapLastMoveDate), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).MapLastMoveDate(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.MapLastMoveDate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (MapLastMoveDate), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus MapLastMoveDate()
    {
      return this.MapLastMoveDate((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus MapLastMoveDate(ContainerTxn containerTxn)
    {
      return this.MapLastMoveDate(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus MapLastMoveDate(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.MapLastMoveDate(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ProcessComputation(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessComputation(ContainerTxn containerTxn)
    {
      return this.ProcessComputation(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ProcessComputation(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessSpecBusinessRule(
      ContainerTxn containerTxn,
      ContainerTxn_ProcessSpecBusinessRule_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessSpecBusinessRule), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ProcessSpecBusinessRule(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ProcessSpecBusinessRule, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessSpecBusinessRule), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessSpecBusinessRule()
    {
      return this.ProcessSpecBusinessRule((ContainerTxn) null, (ContainerTxn_ProcessSpecBusinessRule_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessSpecBusinessRule(ContainerTxn containerTxn)
    {
      return this.ProcessSpecBusinessRule(containerTxn, (ContainerTxn_ProcessSpecBusinessRule_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessSpecBusinessRule(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ProcessSpecBusinessRule(containerTxn, (ContainerTxn_ProcessSpecBusinessRule_Parameters) null, request, out result);
    }

    public ResultStatus ProcessStopTimer(
      ContainerTxn containerTxn,
      ContainerTxn_ProcessStopTimer_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessStopTimer), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ProcessStopTimer(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ProcessStopTimer, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessStopTimer), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessStopTimer()
    {
      return this.ProcessStopTimer((ContainerTxn) null, (ContainerTxn_ProcessStopTimer_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessStopTimer(ContainerTxn containerTxn)
    {
      return this.ProcessStopTimer(containerTxn, (ContainerTxn_ProcessStopTimer_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessStopTimer(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ProcessStopTimer(containerTxn, (ContainerTxn_ProcessStopTimer_Parameters) null, request, out result);
    }

    public ResultStatus ProcessTimerDisposition(
      ContainerTxn containerTxn,
      ContainerTxn_ProcessTimerDisposition_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessTimerDisposition), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ProcessTimerDisposition(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ProcessTimerDisposition, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessTimerDisposition), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessTimerDisposition()
    {
      return this.ProcessTimerDisposition((ContainerTxn) null, (ContainerTxn_ProcessTimerDisposition_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessTimerDisposition(ContainerTxn containerTxn)
    {
      return this.ProcessTimerDisposition(containerTxn, (ContainerTxn_ProcessTimerDisposition_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessTimerDisposition(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ProcessTimerDisposition(containerTxn, (ContainerTxn_ProcessTimerDisposition_Parameters) null, request, out result);
    }

    public ResultStatus ProcessTimersESignatures(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessTimersESignatures), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ProcessTimersESignatures(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ProcessTimersESignatures, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessTimersESignatures), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessTimersESignatures()
    {
      return this.ProcessTimersESignatures((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessTimersESignatures(ContainerTxn containerTxn)
    {
      return this.ProcessTimersESignatures(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ProcessTimersESignatures(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ProcessTimersESignatures(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveDataCollectionDef(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveDataCollectionDef), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ResolveDataCollectionDef(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ResolveDataCollectionDef, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveDataCollectionDef), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveDataCollectionDef()
    {
      return this.ResolveDataCollectionDef((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ResolveDataCollectionDef(ContainerTxn containerTxn)
    {
      return this.ResolveDataCollectionDef(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ResolveDataCollectionDef(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ResolveDataCollectionDef(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ResolveParametricData(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ResolveParametricData(ContainerTxn containerTxn)
    {
      return this.ResolveParametricData(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ResolveParametricData(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus SaveContainerDetail(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (SaveContainerDetail), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).SaveContainerDetail(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.SaveContainerDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveContainerDetail), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveContainerDetail()
    {
      return this.SaveContainerDetail((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus SaveContainerDetail(ContainerTxn containerTxn)
    {
      return this.SaveContainerDetail(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus SaveContainerDetail(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.SaveContainerDetail(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus SetESigProcessTimerDetails(
      ContainerTxn containerTxn,
      ContainerTxn_SetESigProcessTimerDetails_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (SetESigProcessTimerDetails), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).SetESigProcessTimerDetails(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.SetESigProcessTimerDetails, (ContainerTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetESigProcessTimerDetails), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetESigProcessTimerDetails()
    {
      return this.SetESigProcessTimerDetails((ContainerTxn) null, (ContainerTxn_SetESigProcessTimerDetails_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus SetESigProcessTimerDetails(ContainerTxn containerTxn)
    {
      return this.SetESigProcessTimerDetails(containerTxn, (ContainerTxn_SetESigProcessTimerDetails_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus SetESigProcessTimerDetails(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.SetESigProcessTimerDetails(containerTxn, (ContainerTxn_SetESigProcessTimerDetails_Parameters) null, request, out result);
    }

    public ResultStatus SetSpecInContainer(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (SetSpecInContainer), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).SetSpecInContainer(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.SetSpecInContainer, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetSpecInContainer), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetSpecInContainer()
    {
      return this.SetSpecInContainer((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus SetSpecInContainer(ContainerTxn containerTxn)
    {
      return this.SetSpecInContainer(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus SetSpecInContainer(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.SetSpecInContainer(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus StartTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (StartTimers), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).StartTimers(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.StartTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (StartTimers), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus StartTimers()
    {
      return this.StartTimers((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus StartTimers(ContainerTxn containerTxn)
    {
      return this.StartTimers(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus StartTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.StartTimers(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus StartTransactionTaskTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (StartTransactionTaskTimers), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).StartTransactionTaskTimers(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.StartTransactionTaskTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (StartTransactionTaskTimers), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus StartTransactionTaskTimers()
    {
      return this.StartTransactionTaskTimers((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus StartTransactionTaskTimers(ContainerTxn containerTxn)
    {
      return this.StartTransactionTaskTimers(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus StartTransactionTaskTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.StartTransactionTaskTimers(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus StopTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (StopTimers), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).StopTimers(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.StopTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (StopTimers), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus StopTimers()
    {
      return this.StopTimers((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus StopTimers(ContainerTxn containerTxn)
    {
      return this.StopTimers(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus StopTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.StopTimers(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateAllowedTxnChildContainers(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateAllowedTxnChildContainers), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ValidateAllowedTxnChildContainers(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ValidateAllowedTxnChildContainers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateAllowedTxnChildContainers), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateAllowedTxnChildContainers()
    {
      return this.ValidateAllowedTxnChildContainers((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateAllowedTxnChildContainers(ContainerTxn containerTxn)
    {
      return this.ValidateAllowedTxnChildContainers(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateAllowedTxnChildContainers(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ValidateAllowedTxnChildContainers(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateAllowedTxnParentContainer(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateAllowedTxnParentContainer), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ValidateAllowedTxnParentContainer(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ValidateAllowedTxnParentContainer, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateAllowedTxnParentContainer), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateAllowedTxnParentContainer()
    {
      return this.ValidateAllowedTxnParentContainer((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateAllowedTxnParentContainer(ContainerTxn containerTxn)
    {
      return this.ValidateAllowedTxnParentContainer(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateAllowedTxnParentContainer(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ValidateAllowedTxnParentContainer(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateAllowedTxns(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateAllowedTxns), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ValidateAllowedTxns(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ValidateAllowedTxns, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateAllowedTxns), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateAllowedTxns()
    {
      return this.ValidateAllowedTxns((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateAllowedTxns(ContainerTxn containerTxn)
    {
      return this.ValidateAllowedTxns(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateAllowedTxns(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ValidateAllowedTxns(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateContainerStatus(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateContainerStatus), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ValidateContainerStatus(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ValidateContainerStatus, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateContainerStatus), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateContainerStatus()
    {
      return this.ValidateContainerStatus((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateContainerStatus(ContainerTxn containerTxn)
    {
      return this.ValidateContainerStatus(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateContainerStatus(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ValidateContainerStatus(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateSpecTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateSpecTimers), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ValidateSpecTimers(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ValidateSpecTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateSpecTimers), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateSpecTimers()
    {
      return this.ValidateSpecTimers((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateSpecTimers(ContainerTxn containerTxn)
    {
      return this.ValidateSpecTimers(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateSpecTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ValidateSpecTimers(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateStopTimersESigRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateStopTimersESigRequirements), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ValidateStopTimersESigRequirements(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ValidateStopTimersESigRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateStopTimersESigRequirements), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateStopTimersESigRequirements()
    {
      return this.ValidateStopTimersESigRequirements((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateStopTimersESigRequirements(ContainerTxn containerTxn)
    {
      return this.ValidateStopTimersESigRequirements(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateStopTimersESigRequirements(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ValidateStopTimersESigRequirements(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateTimers), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ValidateTimers(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ValidateTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateTimers), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateTimers()
    {
      return this.ValidateTimers((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateTimers(ContainerTxn containerTxn)
    {
      return this.ValidateTimers(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ValidateTimers(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateTransactionTaskTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Parameters parameters,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateTransactionTaskTimers), (DCObject) containerTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ValidateTransactionTaskTimers(this._UserProfile, containerTxn, parameters, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(containerTxn, ContainerTxnMethods.ValidateTransactionTaskTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateTransactionTaskTimers), res, (DCObject) containerTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateTransactionTaskTimers()
    {
      return this.ValidateTransactionTaskTimers((ContainerTxn) null, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateTransactionTaskTimers(ContainerTxn containerTxn)
    {
      return this.ValidateTransactionTaskTimers(containerTxn, (ContainerTxn_Parameters) null, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ValidateTransactionTaskTimers(
      ContainerTxn containerTxn,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ValidateTransactionTaskTimers(containerTxn, (ContainerTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject containerTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ContainerTxn) containerTxn, (ContainerTxn_Parameters) parameters, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject containerTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus actions = this.GetActions((ContainerTxn) containerTxn, (ContainerTxn_Parameters) parameters, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject containerTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ContainerTxn) containerTxn, (ContainerTxn_Parameters) parameters, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containerTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainerTxn) containerTxn, (ContainerTxn_LoadESigDetails_Parameters) parameters, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject containerTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ContainerTxn) containerTxn, (ContainerTxn_Parameters) parameters, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject containerTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ContainerTxn) containerTxn, (ContainerTxn_Parameters) parameters, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containerTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus resultStatus = this.Load((ContainerTxn) containerTxn, (ContainerTxn_Parameters) parameters, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerTxn) containerTxn, (ContainerTxn_Parameters) parameters, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      try
      {
        ContainerTxnMethod[] methods = new ContainerTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerTxn cdo,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      try
      {
        return ((IContainerTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerTxn) cdo, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.GetEnvironment((ContainerTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerTxn cdo,
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      result = (ContainerTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerTxnMethod(cdo, ContainerTxnMethods.ExecuteTransaction, (ContainerTxn_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerTxn) cdo, (ContainerTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerTxn_Request) null, out ContainerTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerTxn_Request request,
      out ContainerTxn_Result result)
    {
      return this.ExecuteTransaction((ContainerTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerTxnMethod(cdo, ContainerTxnMethods.AddDataTransaction, (ContainerTxn_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ContainerTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
