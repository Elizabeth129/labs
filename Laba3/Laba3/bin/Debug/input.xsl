<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output
    method="html" />
  <xsl:template match="/">
    <html>
      <body>
        <table border ="1">
          <TR>
            <th>PIP</th>
            <th>Faculty</th>
            <th>Department</th>
            <th>Publications</th>
          </TR>
          <xsl:for-each select="ScientificPublicDatabase/ScientificPublic">
            <tr>
              <td>
                <xsl:value-of select="PIP"/>
              </td>
              <td>
                <xsl:value-of select="faculty"/>
              </td>
              <td>
                <xsl:value-of select="department"/>
              </td>
              <td>
                <xsl:for-each select="publication">
                  <xsl:value-of  select="."/>
                <br/>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>