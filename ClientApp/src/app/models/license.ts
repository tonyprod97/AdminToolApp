export class License {
  licenseKey: string;
  idCustomer: string;
  usedLicenses: number;
  totalLicenses: number;
  version: number;
  validUntil?: string;
  active?: number;
  numExpired?: number;
  canExtendUntil?: string;
}
