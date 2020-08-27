// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PortalMenuDefinitionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PortalMenuDefinitionMaintService : NamedDataObjectMaintBase
  {
    public PortalMenuDefinitionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPortalMenuDefinitionMaintService), userProfile);
    }

    public ResultStatus Delete(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).Delete(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus Delete(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.Delete(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus Delete(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.Delete(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).Freeze(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus Freeze(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.Freeze(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus Freeze(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.Freeze(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.GetWIPMsgs(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.GetWIPMsgs(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).Load(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus Load(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.Load(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus Load(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.Load(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_LoadESigDetails_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).LoadESigDetails(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.LoadESigDetails, (PortalMenuDefinitionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_LoadESigDetails_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.LoadESigDetails(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_LoadESigDetails_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.LoadESigDetails(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).New(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus New(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.New(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus New(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.New(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).NewCopy(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.NewCopy(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus NewCopy(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.NewCopy(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).SaveAs(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.SaveAs(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus SaveAs(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.SaveAs(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Parameters parameters,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).UnFreeze(this._UserProfile, portalMenuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(portalMenuDefinitionMaint, PortalMenuDefinitionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) portalMenuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PortalMenuDefinitionMaint) null, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint)
    {
      return this.UnFreeze(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PortalMenuDefinitionMaint portalMenuDefinitionMaint,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.UnFreeze(portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_LoadESigDetails_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.New((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Load((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject portalMenuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PortalMenuDefinitionMaint) portalMenuDefinitionMaint, (PortalMenuDefinitionMaint_Parameters) parameters, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      try
      {
        PortalMenuDefinitionMaintMethod[] methods = new PortalMenuDefinitionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPortalMenuDefinitionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PortalMenuDefinitionMaint cdo,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      try
      {
        return ((IPortalMenuDefinitionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PortalMenuDefinitionMaint) cdo, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.GetEnvironment((PortalMenuDefinitionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PortalMenuDefinitionMaint cdo,
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      result = (PortalMenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMenuDefinitionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(cdo, PortalMenuDefinitionMaintMethods.ExecuteTransaction, (PortalMenuDefinitionMaint_Parameters) null));
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
        PortalMenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PortalMenuDefinitionMaint) cdo, (PortalMenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PortalMenuDefinitionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PortalMenuDefinitionMaint_Request) null, out PortalMenuDefinitionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PortalMenuDefinitionMaint_Request request,
      out PortalMenuDefinitionMaint_Result result)
    {
      return this.ExecuteTransaction((PortalMenuDefinitionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PortalMenuDefinitionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PortalMenuDefinitionMaintMethod(cdo, PortalMenuDefinitionMaintMethods.AddDataTransaction, (PortalMenuDefinitionMaint_Parameters) null));
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
        return this.AddDataTransaction((PortalMenuDefinitionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
