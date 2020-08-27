// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OrganizationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OrganizationMaintService : NamedDataObjectMaintBase
  {
    public OrganizationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOrganizationMaintService), userProfile);
    }

    public ResultStatus Delete(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).Delete(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus Delete(OrganizationMaint organizationMaint)
    {
      return this.Delete(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus Delete(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.Delete(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).Freeze(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus Freeze(OrganizationMaint organizationMaint)
    {
      return this.Freeze(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus Freeze(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.Freeze(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(OrganizationMaint organizationMaint)
    {
      return this.GetWIPMsgs(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.GetWIPMsgs(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).Load(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus Load(OrganizationMaint organizationMaint)
    {
      return this.Load(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus Load(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.Load(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OrganizationMaint organizationMaint,
      OrganizationMaint_LoadESigDetails_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).LoadESigDetails(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.LoadESigDetails, (OrganizationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OrganizationMaint) null, (OrganizationMaint_LoadESigDetails_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(OrganizationMaint organizationMaint)
    {
      return this.LoadESigDetails(organizationMaint, (OrganizationMaint_LoadESigDetails_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.LoadESigDetails(organizationMaint, (OrganizationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).New(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus New(OrganizationMaint organizationMaint)
    {
      return this.New(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus New(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.New(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).NewCopy(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus NewCopy(OrganizationMaint organizationMaint)
    {
      return this.NewCopy(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus NewCopy(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.NewCopy(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus ProcessNameChange(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (ProcessNameChange), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).ProcessNameChange(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.ProcessNameChange, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessNameChange), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessNameChange()
    {
      return this.ProcessNameChange((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus ProcessNameChange(OrganizationMaint organizationMaint)
    {
      return this.ProcessNameChange(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus ProcessNameChange(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.ProcessNameChange(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).SaveAs(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus SaveAs(OrganizationMaint organizationMaint)
    {
      return this.SaveAs(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus SaveAs(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.SaveAs(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Parameters parameters,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) organizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).UnFreeze(this._UserProfile, organizationMaint, parameters, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(organizationMaint, OrganizationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) organizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((OrganizationMaint) null, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus UnFreeze(OrganizationMaint organizationMaint)
    {
      return this.UnFreeze(organizationMaint, (OrganizationMaint_Parameters) null, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      OrganizationMaint organizationMaint,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.UnFreeze(organizationMaint, (OrganizationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((OrganizationMaint) organizationMaint, (OrganizationMaint_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((OrganizationMaint) organizationMaint, (OrganizationMaint_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OrganizationMaint) organizationMaint, (OrganizationMaint_LoadESigDetails_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.New((OrganizationMaint) organizationMaint, (OrganizationMaint_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((OrganizationMaint) organizationMaint, (OrganizationMaint_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((OrganizationMaint) organizationMaint, (OrganizationMaint_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((OrganizationMaint) organizationMaint, (OrganizationMaint_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.Load((OrganizationMaint) organizationMaint, (OrganizationMaint_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject organizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrganizationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OrganizationMaint) organizationMaint, (OrganizationMaint_Parameters) parameters, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      try
      {
        OrganizationMaintMethod[] methods = new OrganizationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOrganizationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OrganizationMaint cdo,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      try
      {
        return ((IOrganizationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OrganizationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((OrganizationMaint) cdo, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.GetEnvironment((OrganizationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OrganizationMaint cdo,
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      result = (OrganizationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrganizationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OrganizationMaintMethod(cdo, OrganizationMaintMethods.ExecuteTransaction, (OrganizationMaint_Parameters) null));
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
        OrganizationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OrganizationMaint) cdo, (OrganizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OrganizationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (OrganizationMaint_Request) null, out OrganizationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OrganizationMaint_Request request,
      out OrganizationMaint_Result result)
    {
      return this.ExecuteTransaction((OrganizationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OrganizationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OrganizationMaintMethod(cdo, OrganizationMaintMethods.AddDataTransaction, (OrganizationMaint_Parameters) null));
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
        return this.AddDataTransaction((OrganizationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
